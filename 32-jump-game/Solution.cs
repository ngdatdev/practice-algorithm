namespace _32_jump_game
{
    public class Solution
    {
        public bool CanJump(int[] nums)
        {
            var lengthJump = nums[0];

            for (int i = 1; i <= nums.Length - 1; i++)
            {
                if(lengthJump < nums[i]) {
                    lengthJump = nums[i];
                }
                lengthJump--;
            }
            return lengthJump == 0;
        }
    }
}
