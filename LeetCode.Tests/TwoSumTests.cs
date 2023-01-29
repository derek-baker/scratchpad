namespace LeetCode;

using LeetCode.Solutions;
using Xunit;

public class TwoSumTests
{
    [Theory]
    [InlineData(new int[] {2,7,11,15}, 9, new int[] {0,1})]
    [InlineData(new int[] {3,2,4}, 6, new int[] {1,2})]
    [InlineData(new int[] {3,3}, 6, new int[] {0,1})]
    [InlineData(new int[] {2,5,5,11}, 10, new int[] {1,2})]
    public void TwoSumHandlesCases(int[] nums, int target, int[] expected)
    {
        // Arrange
        var solution = new SolutionTwoSum();
        
        // Act
        var actual = solution.TwoSum(nums, target);

        // Assert
        Assert.Equal(expected, actual);
    }
}