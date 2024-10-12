using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a queue with the following people and turns: Bob (1), Tim (10), Sue (5)
    // Expected Result: Tim (10)
    // Defect(s) Found: 
    public void TestPriority_Dequeue_WithDifferentPriorities_ReturnsHighestPriorityItem()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Bob", 1);
        priorityQueue.Enqueue("Tim", 10);
        priorityQueue.Enqueue("Sue", 5);
        var result = priorityQueue.Dequeue();
        Assert.AreEqual("Tim", result);
    }

    [TestMethod]
    // Scenario: Create a queue with following people with the same order of priority
    // Expected Result: return the oldest in the list
    // Defect(s) Found: 
    public void TestPriority_Dequeue_WithSamePriority_ReturnsInFIFOOrder()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Bob", 5);
        priorityQueue.Enqueue("Tim", 5);
        priorityQueue.Enqueue("Sue", 5);

        Assert.AreEqual("Bob", priorityQueue.Dequeue());
        Assert.AreEqual("Tim", priorityQueue.Dequeue());
        Assert.AreEqual("Sue", priorityQueue.Dequeue());
    }

    // Add more test cases as needed below.
}