namespace ColorSort;
public class Class1
{
    public void SortColors(int[] nums)
    {
        int red = 0;
        int white = 0;
        int blue = 0;
        foreach (int i in nums)
        {
            switch (i)
            {
                case 0:
                    red++;
                    break;
                case 1:
                    white++;
                    break;
                case 2:
                    blue++;
                    break;
                default:
                    break;
            }
        }
        Console.WriteLine($"Red: {red}, White: {white}, Blue: {blue}");
        for (int i = 0; i < red; i++)
        {
            nums[i] = 0;
        }
        for (int i = red; i < white + red; i++)
        {
            nums[i] = 1;
        }
        for (int i = red + white; i < nums.Length; i++)
        {
            nums[i] = 2;
        }
    }
}
