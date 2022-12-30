
// Given an array of ints of even length, return a new array length 2 containing the middle two elements from the original array. The original array will be length 2 or more.


// makeMiddle([1, 2, 3, 4]) → [2, 3]
// makeMiddle([7, 1, 2, 3, 4, 9]) → [2, 3]
// makeMiddle([1, 2]) → [1, 2]

public int[] makeMiddle(int[] nums) 
{
  int mid1 = nums.length / 2;
  int mid2 = mid1 - 1;
  
  return new int[] {nums[mid2], nums[mid1]};
}
