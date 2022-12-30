
// Given an array of ints of odd length, return a new array length 3 containing the elements from the middle of the array. The array length will be at least 3.


// midThree([1, 2, 3, 4, 5]) → [2, 3, 4]
// midThree([8, 6, 7, 5, 3, 0, 9]) → [7, 5, 3]
// midThree([1, 2, 3]) → [1, 2, 3]

public int[] midThree(int[] nums)
{
  int mid2 = nums.length / 2;
  int mid1 = mid2 - 1;
  int mid3 = mid2 + 1;
  
  return new int[] {nums[mid1], nums[mid2], nums[mid3]};
}
