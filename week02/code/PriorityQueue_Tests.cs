using System.Diagnostics;
using System.Linq.Expressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario:  Create a queue with the values and priority of ["Low", 1; "High", 5; "Medium", 3]. Dequeue based on priority level.
    // Expected Result: it is expected that the dequeued values and priorities will be ["High", 5; "Medium", 3; "Low" 1].
    // Defect(s) Found: PriorityQueue Dequeue never checked the last item in the queue due to the "index < _queue.Count -1" so "-1" was removed and I also changed in index to 0. Dequeue never removed an item at all, always returning the same high-priority item so i added _queue.RemoveAt(highPriorityIndex) before the return. I put it in the wrong place where it removed the item early so then changed it to the last thing to do before returning.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();  //Create the queue
        priorityQueue.Enqueue("Low", 1);          //Enqueue the items in order
        priorityQueue.Enqueue("High", 5);
        priorityQueue.Enqueue("Medium", 3);

        string[] expectedResult = ["High", "Medium", "Low"];   //Build an expectedResult array with the name sequence
        for (int i = 0; i < expectedResult.Length; i++)        //Loop through the total Dequeue calls and assert each one
        {
            var value = priorityQueue.Dequeue();
            Debug.WriteLine($"Dequeued order: {value} for test 1.");
            Assert.AreEqual(expectedResult[i], value);
        }
    }



    [TestMethod]
    // Scenario: Create a queue with the values and priority of ["First", 3; "Second", 5; "Third", 1; and "Fourth" 5]
    // Expected Result: ["Second, 5", "Fourth, 5", "First, 3", "Third, 1"]
    // Defect(s) Found: When the test was run to test for a tie break we ran into a problem because the code was comparing >=. Once I changed the code in the if statement to just compare if the values were >, the program ran successfully. 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();       //Create the queue
        priorityQueue.Enqueue("First", 3);                //Enqueue the items in order
        priorityQueue.Enqueue("Second", 5);
        priorityQueue.Enqueue("Third", 1);
        priorityQueue.Enqueue("Fourth", 5);

        string[] expectedResult = ["Second", "Fourth", "First", "Third"];       //Build an expectedResult array with the name sequence
        for (int i = 0; i < expectedResult.Length; i++)        //Loop through the total Dequeue calls and assert each one
        {
            var value = priorityQueue.Dequeue();
            Debug.WriteLine($"Dequeued order: {value} for test 2.");
            Assert.AreEqual(expectedResult[i], value);
        }
    }

    [TestMethod]
    // Scenario: Try to dequeue from an empty PriorityQueue .
    // Expected Result: An InvalidOperationException should be shown with the message " The queue is empty."
    // Defect Found: None. original code was correct

    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();
        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
        catch (AssertFailedException)
        {
            throw;
        }
        catch (Exception e)
        {
            Assert.Fail(string.Format("Unexpected exception type{0} caught: {1}", e.GetType(), e.Message));
        }
    }
}