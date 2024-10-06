using System.ComponentModel.Design;
using System.Reflection;
using System.Text;

namespace Leet;

class Program
{
	static void Main(string[] args)
	{
		//Merge Sorted Array
		// int[] int1 = [1,2,3,0,0,0];
		// int[] int2 = [2,5,6];
		// Merge(int1,3,int2,3);
		// Console.WriteLine("Hello, World!");

		//Remove Element
		// int[] nums = [3,2,2,3]; 
		// int val = 3;
		// RemoveElement(nums, val);

		//Remove Duplicates from Sorted Array
		// int[] nums = [0,0,1,1,1,2,2,3,3,4];
		// RemoveDuplicates(nums);

		//Remove Duplicates from Sorted Array II
		// int[] nums = [1,1,1,2,2,3];
		// RemoveDuplicatesII(nums);

		//Majority Element
		// int[] nums = [8,8,7,7,7];
		// MajorityElement(nums);

		//Rotate Array
		// int[] nums = [1,2,3,4,5,6,7]; 
		// int k = 3;
		// Rotate(nums, k);

		//Best Time to Buy and Sell Stock
		//int[] prices = [7,1,5,3,6,4];
		//int[] prices = [7,6,4,3,1];
		// int[] prices = [2,4,1];
		// MaxProfit(prices);

		//Linked List Cycle
		// LinkedList<int> myList = new LinkedList<int>(); 
		// ListNode head = new ListNode(3);//[3,2,0,-4];
		// //pos = 1
		// HasCycle(head);

		//Merge Two Sorted Lists
		// ListNode list1 = new ListNode(1);
		// list1.next = new ListNode(2);
		// list1.next.next = new ListNode(4);
		// ListNode list2 = new(1);
		// list2.next = new ListNode(3);
		// list2.next.next = new ListNode(4);
		// ListNode list1 = new ListNode();
		// ListNode list2 = new();
		// MergeTwoLists(list1, list2);

		// int n = 10;
		// //pick = 6
		// GuessNumber(n);

		//Find Peak Element
		// int[] nums = [1, 2, 3];//[6, 5, 4, 3, 2, 3, 2];//[1];//[1, 2]; //[1,2,3,1]; Output = 2
		// FindPeakElement(nums);
		//Output = 1

		//Jump Game
		// int[] nums = [1, 0, 1, 0];//[0, 2, 3];//[2, 3, 1, 1, 4];//[3, 2, 1, 0, 4];//[2, 5, 0, 0];//[2, 3, 1, 1, 4]; //[0];//[2, 5, 0, 0];// //[3, 2, 1, 0, 4];
		// CanJump(nums);
		//Output = True

		//Length of Last Word
		// string s = "   fly me   to   the moon  ";
		// LengthOfLastWord(s);

		//Longest Common Prefix
		// string[] strs = ["flower", "flow", "flight"];
		// LongestCommonPrefix(strs);

		//Find the Index of the First Occurrence in a String
		// string haystack = "sadbutsad", needle = "sad";
		// StrStr(haystack, needle);

		//Valid Palindrome
		// string s = "0P";
		// IsPalindrome(s);

		//Palindrome Number
		// int x = 121;
		// IsPalindrome(x);

		//Amazon - The kth Factor of n
		// int n = 12, k = 3;
		// KthFactor(n, k);

		//Amazon - Optimal Partition of String
		//string s = "abacaba";
		//PartitionString(s);

		//Valid Parentheses
		// string s = "({[)";//"))";//"([}}])";//"()[]{}";//"((";//"([])";//"()"; //"[[[]"; //"([])"
		// IsValid(s);

		//Fizz Buzz
		// int n = 3;
		// FizzBuzz(n);

		//Plus One
		// int[] digits = [9];
		// PlusOne(digits);

		//Climbing Stairs
		// int n = 3;
		// ClimbStairs(n);

		// Remove Duplicates from Sorted List
		//[1,1,2,3,3]
		// ListNode head = new ListNode(1);
		// head.next = new ListNode(1);
		// head.next.next = new ListNode(2);
		// head.next.next.next = new ListNode(3);
		// head.next.next.next.next = new ListNode(3);
		// DeleteDuplicates(head);

		// Remove Duplicates from Sorted List II
		// ListNode head = new ListNode(1);
		// head.next = new ListNode(1);
		// head.next.next = new ListNode(1);
		// head.next.next.next = new ListNode(2);
		// head.next.next.next.next = new ListNode(3);
		// DeleteDuplicatesII(head);

		// Search in Rotated Sorted Array II
		// int[] nums = [2, 5, 6, 0, 0, 1, 2];
		// int target = 0;
		// Search(nums, target);

		//Reverse Words in a String
		// string s = "the sky is blue";
		// string s2 = "a good   example";
		// ReverseWords(s2);

		// Missing Number
		// int[] nums = [3, 0, 1];
		// MissingNumber(nums);

		//Convert Sorted Array to Binary Search Tree
		// int[] nums = [-10, -3, 0, 5, 9];
		// SortedArrayToBST(nums);

		// // Reverse String
		// char[] chars = ['h', 'e', 'l', 'l', 'o'];
		// ReverseString(chars);

		// Reverse Linked List
		//[1, 2, 3, 4, 5]
		// ListNode head = new ListNode(1);
		// head.next = new ListNode(2);
		// head.next.next = new ListNode(3);
		// head.next.next.next = new ListNode(4);
		// head.next.next.next.next = new ListNode(5);
		// ReverseList(head);

		// Reverse Bits
		// uint n = 43261596;
		// ReverseBits(n);

		// Happy Number
		// int n = 11;
		// IsHappy(n);

		// Single Number
		// int[] nums = [2, 2, 1]; //[4, 1, 2, 1, 2];
		// SingleNumber(nums);

		// Move Zeroes
		int[] nums = [0, 1, 0, 3, 12];
		MoveZeroes(nums);
	}

	//Merge Sorted Array
	public static void Merge(int[] nums1, int m, int[] nums2, int n)
	{
		int j = 0;

		for (int i = 0; i < nums1.Length; i++)
		{
			if (nums1[i] == 0 && n > j)
			{
				nums1[i] = nums2[j];
				j++;
			}
		}
		Array.Sort(nums1);
	}

	//Remove Element
	public static int RemoveElement(int[] nums, int val)
	{
		int k = 0;

		for (int i = 0; i < nums.Length; i++)
		{
			if (nums[i] != val)
			{
				nums[k++] = nums[i];
			}
		}
		return k;
	}

	//Remove Duplicates from Sorted Array (Supposed to do this in-place)
	public static int RemoveDuplicates(int[] nums)
	{
		// int[] distinctNums = nums.Distinct().ToArray();
		// for (int i = 0; i < distinctNums.Length; i++)
		// {
		//     nums[i] = distinctNums[i];
		// } 

		// return distinctNums.Length;

		if (nums.Length == 0)
		{
			return 0;
		}

		int j = 0;
		for (int i = 1; i < nums.Length; i++)
		{
			if (nums[j] != nums[i])
			{
				nums[++j] = nums[i];
			}
		}
		return j + 1;
	}

	//Remove Duplicates from Sorted Array II
	public static int RemoveDuplicatesII(int[] nums)
	{
		if (nums.Length <= 2)
		{ // If array length is 2 or less, no duplicates to remove
			return nums.Length;
		}

		int count = 2;

		for (int i = 2; i < nums.Length; i++)
		{ // Iterate through the array starting from the third element
			if (nums[i] != nums[count - 2])
			{ // If current element is different from element at count-2, it is a non-duplicate
				nums[count] = nums[i]; // Overwrite duplicates with non-duplicates
				count++; // Increment count of non-duplicates
			}
		}
		return count; // Length of modified array with duplicates removed
	}

	//Majority Element
	public static int MajorityElement(int[] nums)
	{
		int len = nums.Length;
		float occurence = (float)len / 2;
		int c = 0;

		for (int j = 0; j < len; j++)
		{
			float count = 0f;
			c = nums[j];
			for (int i = 0; i < len; i++)
			{
				if (c == nums[i])
				{
					count++;
				}
			}
			if (count >= occurence)
			{
				return c;
			}
		}
		return c;
	}

	//Rotate Array /*Works in VSCode but not LeetCode*/
	public static void Rotate(int[] nums, int k)
	{
		int[] newNums = new int[nums.Length];

		for (int i = nums.Length - 1; i >= 0; i--)
		{
			int j = i + k;
			if (j >= nums.Length)
			{
				int overage = j - nums.Length;
				newNums[overage] = nums[i];
			}
			else
			{
				newNums[j] = nums[i];
			}
		}
		nums = newNums;
	}

	//Best Time to Buy and Sell Stock
	public static int MaxProfit(int[] prices)
	{
		int min = prices[0], maxProfit = 0;

		for (int i = 1; i < prices.Length; i++)
		{
			if (prices[i] < min)
				min = prices[i];
			else
			{
				int profit = prices[i] - min;
				if (maxProfit < profit)
					maxProfit = profit;
			}
		}
		return maxProfit;
	}

	//Best Time to Buy and Sell Stock
	public static int MaxProfitII(int[] prices)
	{

		return 1;
	}

	//Linked List Cycle (Tortoise & Hare) *needs more work
	public static bool HasCycle(ListNode head)
	{
		ListNode slow_pointer = head, fast_pointer = head;
		while (fast_pointer != null && fast_pointer.next != null)
		{
			slow_pointer = slow_pointer.next;
			fast_pointer = fast_pointer.next.next;
			if (slow_pointer == fast_pointer)
			{
				return true;
			}
		}
		return false;
	}

	//Merge Two Sorted Lists
	public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
	{
		if (list1 == null && list2 == null)
			return null;
		else if (list1 == null && list2 != null)
			return list2;
		else if (list2 == null && list1 != null)
			return list1;
		else
		{
			List<int> list = new();
			while (list1 != null)
			{
				list.Add(list1.val);
				list1 = list1.next;
			}
			while (list2 != null)
			{
				list.Add(list2.val);
				list2 = list2.next;
			}

			list.Sort();

			ListNode retNode = new(list[0]);
			ListNode head = retNode;
			foreach (int value in list)
			{
				retNode.next = new ListNode(value);
				retNode = retNode.next;
			}

			head = head.next;
			return head;
		}
	}

	//Guess Number Higher or Lower
	//Binary Search O(log n)
	/** 
	* Forward declaration of guess API.
	* @param  num   your guess
	* @return 	     -1 if num is higher than the picked number
	*			      1 if num is lower than the picked number
	*               otherwise return 0
	* int guess(int num);
	*/
	/*works but too slow*/
	// for (int i = 1; i <= n; i++) {
	//     int response = guess(i); //guess API
	//     if (response == -1) { //higher
	//         continue;
	//     }
	//     else pick = i;
	// }

	// public static int GuessNumber(int n) {
	//     if (n == 1) {
	//         return n; 
	//     }

	//     int min = 1;
	//     int max = n;

	//     while (min <= max) {
	//         int split = min + (max - min) / 2;
	//         int response = guess(split); //API

	//         if (response == 0){
	//             return split;
	//         }
	//         else if (response == -1){
	//             max = split - 1;
	//         }
	//         else{
	//             min = split + 1;
	//         }
	//     }
	//     return -1;
	// }

	//Find Peak Element
	public static int FindPeakElement(int[] nums)
	{
		//first option, fastest
		for (int i = 0; i < nums.Length; i++)
		{
			if (nums.Length == 1)
			{
				return 0;
			}
			else if (nums.Length == 2)
			{
				if (nums[i] > nums[i + 1])
				{
					return 0;
				}
				else return 1;
			}
			else if (nums.Length - 1 == i)
			{
				return i;
			}
			else
			{
				if (nums[i] > nums[i + 1])
				{
					if (i == 0)
					{
						return 0;
					}
					else
					{
						if (nums[i] > nums[i - 1])
						{
							return i;
						}
					}
				}
				else continue;
			}
		}
		return 0; //if array length is 1

		// 	//second option but slower
		// 	int maxValue = nums.Max();
		// 	int maxIndex = nums.ToList().IndexOf(maxValue);
		// 	return maxIndex;
	}

	//Jump Game **
	public static bool CanJump(int[] nums)
	{
		int len = nums.Length;
		int lastIndex = len - 1;

		if (len == 1) return true;
		if (nums[0] == 0) return false;

		for (int i = lastIndex; i >= 0; i--)
		{
			int maxJump = nums[i];
			if (i + maxJump >= lastIndex)
			{
				if (i == 0) return true;
				lastIndex = i;
			}
		}
		return false;
	}

	//Length of Last Word *faster ways to do this
	public static int LengthOfLastWord(string s)
	{
		string[] split = s.Split(Array.Empty<char>(), StringSplitOptions.RemoveEmptyEntries);
		int sizeOfLast = split[split.Length - 1].Length;
		return sizeOfLast;
	}

	//Longest Common Prefix **
	public static string LongestCommonPrefix(string[] strs)
	{
		string s = "";
		for (int i = 0; i < strs[0].Length; i++)
		{
			for (int j = 1; j < strs.Length; j++)
			{
				if (i >= strs[j].Length || strs[j][i] != strs[0][i])
				{
					return s;
				}
			}
			s += strs[0][i];
		}
		return s;
	}

	//Find the Index of the First Occurrence in a String
	public static int StrStr(string haystack, string needle)
	{
		int i = -1;
		if (haystack.Contains(needle))
		{
			i = haystack.IndexOf(needle);
		}
		return i;
	}

	//Valid Palindrome
	public static bool IsPalindrome(string s)
	{
		char[] arr = s.ToCharArray();
		arr = Array.FindAll<char>(arr, c => char.IsLetterOrDigit(c));
		s = new string(arr);
		char[] arrr = arr;
		Array.Reverse(arrr);
		string c = new string(arrr);

		if (s.Equals(c, StringComparison.CurrentCultureIgnoreCase))
		{
			return true;
		}
		else return false;
	}

	//Palindrome Number
	public static bool IsPalindrome(int x)
	{
		string converted = x.ToString();
		char[] arr = converted.ToCharArray();
		arr = Array.FindAll<char>(arr, c => char.IsDigit(c) || c == '-');
		converted = new string(arr);
		char[] arrr = arr;
		Array.Reverse(arrr);
		string c = new string(arrr);

		if (converted.Equals(c, StringComparison.CurrentCultureIgnoreCase))
		{
			return true;
		}
		else return false;
	}

	//Amazon - The kth Factor of n **
	public static int KthFactor(int n, int k)
	{
		List<int> list = new List<int>();
		for (int i = 1; i <= n; i++)
		{
			if (n % i == 0)
			{
				list.Add(i);
			}
		}

		int factor = -1;
		for (int j = 0; j <= list.Count; j++)
		{
			if (k <= list.Count)
			{
				factor = list[k - 1];
			}
		}
		return factor;
	}

	//Amazon -  Optimal Partition of String
	public static int PartitionString(string s)
	{
		HashSet<char> h = [];
		int z = 1;
		for (int i = 0; i < s.Length; i++)
		{
			if (h.Contains(s[i]))
			{
				z++;
				h.Clear();
			}
			h.Add(s[i]);
		}
		return z;
	}

	//Valid Parentheses *beats 78%
	public static bool IsValid(string s)
	{
		Stack<char> stack = new();
		for (int i = 0; i < s.Length; i++)
		{
			if (stack.Count > 0)
			{
				switch (s[i])
				{
					case ')':
						if (stack.Peek() == '(') stack.Pop();
						else stack.Push(s[i]);
						break;
					case '}':
						if (stack.Peek() == '{') stack.Pop();
						else stack.Push(s[i]);
						break;
					case ']':
						if (stack.Peek() == '[') stack.Pop();
						else stack.Push(s[i]);
						break;
					default:
						stack.Push(s[i]);
						break;
				}
			}
			else stack.Push(s[i]);
		}

		return stack.Count == 0;
	}

	//Fizz Buzz
	public static IList<string> FizzBuzz(int n)
	{
		IList<string> answer = new List<string>(n);

		for (int i = 1; i <= n; i++)
		{
			if (i % 3 == 0 && i % 5 == 0)
				answer.Add("FizzBuzz");
			else if (i % 3 == 0 && i % 5 != 0)
				answer.Add("Fizz");
			else if (i % 5 == 0 && i % 3 != 0)
				answer.Add("Buzz");
			else
			{
				answer.Add(i.ToString());
			}
		}

		return answer;
	}

	//Plus One
	public static int[] PlusOne(int[] digits)
	{
		int len = digits.Length;
		for (int i = len - 1; i >= 0; i--)
		{
			if (i == 0 && digits[i] == 9)
			{
				int[] firstIndexZero = new int[len + 1];
				firstIndexZero[i] = 1;
				return firstIndexZero;
			}
			if (digits[i] < 9)
			{
				digits[i]++;
				return digits;
			}
			digits[i] = 0;
		}

		int[] newNum = new int[len + 1];
		return newNum;
	}

	//Climbing Stairs (Fibonacci Number)
	public static int ClimbStairs(int n)
	{
		if (n == 1) return 1;

		int prev2 = 1, prev1 = 2;
		for (int i = 3; i <= n; i++)
		{
			int current = prev1 + prev2;
			prev2 = prev1;
			prev1 = current;
		}

		return prev1;
	}

	// Remove Duplicates from Sorted List
	public static ListNode DeleteDuplicates(ListNode head)
	{
		if (head != null)
		{
			ListNode p = head;
			while (p.next != null)
			{
				if (p.val == p.next.val)
				{
					ListNode temp = p.next;
					p.next = temp.next;
				}
				else p = p.next;
			}
		}

		return head;
	}

	// Remove Duplicates from Sorted List II *needs more work
	public static ListNode DeleteDuplicatesII(ListNode head)
	{
		ListNode p = head;
		if (head != null)
		{
			while (p.next != null && p.next.next != null)
			{
				if (p.val == p.next.val)
				{
					ListNode temp = p;
					p = temp.next;
				}
				else if (p.next.val == p.next.next.val)
				{
					ListNode temp = p.next;
					p.next = temp.next.next;
				}
				else p = p.next;
			}
		}

		return p;
	}

	// Serach in Rotated Sorted Array II *** do without contains
	public static bool Search(int[] nums, int target)
	{
		List<int> list = new List<int>();
		list = nums.ToList();
		if (list.Contains(target)) return true;
		return false;
	}

	// 	int low = 0, high = nums.Length - 1;

	//         while (low <= high) {
	//             int mid = (low + high) / 2;
	//             if (nums[mid] == target) return true;

	//             if (nums[low] == nums[mid]) {
	//                 low++;
	//                 continue;
	//             }

	//             if (nums[low] <= nums[mid]) {
	//                 if (nums[low] <= target && target <= nums[mid]) high = mid - 1;
	//                 else low = mid + 1;
	//             } else
	// {
	// 	if (nums[mid] <= target && target <= nums[high]) low = mid + 1;
	// 	else high = mid - 1;
	// }
	//         }
	//         return false;

	// Reverse Words in a String
	public static string ReverseWords(string s)
	{
		string[] words = s.Trim().Split(' ');
		StringBuilder reverse = new(words.Length); // mutatable string of chars
		for (int i = words.Length - 1; i >= 0; i--)
		{
			if (string.IsNullOrWhiteSpace(words[i]))
				continue;
			reverse.Append(" " + words[i]);
		}
		return reverse.ToString().Trim();
	}

	// Missing Number
	public static int MissingNumber(int[] nums)
	{
		Array.Sort(nums);
		int n = nums.Length;
		if (nums[0] != 0) return 0;
		if (nums[nums.Length - 1] != n) return n;
		for (int i = 0; i < n - 1; i++)
		{
			if (nums[i + 1] != i + 1) return i + 1;
		}

		return 0;
	}

	//Convert Sorted Array to Binary Search Tree
	public static TreeNode SortedArrayToBST(int[] nums)
	{
		if (nums.Length <= 0)
			return null;

		int mid = nums.Length / 2;
		var tree = new TreeNode(nums[mid]);
		tree.left = SortedArrayToBST(nums[..mid]);
		tree.right = SortedArrayToBST(nums[(mid + 1)..]);

		return tree;
	}

	// Reverse String
	public static void ReverseString(char[] s)
	{
		int i = 0;
		int j = s.Length - 1;
		while (i < j)
		{
			char t = s[i];
			s[i] = s[j];
			s[j] = t;
			i++;
			j--;
		}
	}

	// Reverse Linked List
	public static ListNode ReverseList(ListNode head)
	{
		ListNode t = null;
		while (head != null)
		{
			ListNode nextNode = head.next;
			head.next = t;
			t = head;
			head = nextNode;
		}

		return t;
	}

	// Reverse Bits **need to come back to this
	public static uint ReverseBits(uint n)
	{
		int t = Convert.ToInt32(n);
		string bits = Convert.ToString(t, 2);
		bits.Reverse();
		n = Convert.ToUInt32(bits, 2);
		return n;
	}

	// Happy Number **needs improvement
	public static bool IsHappy(int n)
	{
		double sum = 0;
		List<double> eLoop = new List<double>();
		if (n == 1 || n == 7) return true;
		if (n > 9)
		{
			while (sum != 1)
			{
				sum = 0;
				string s = n.ToString();
				foreach (var c in s)
				{
					double d = Char.GetNumericValue(c);
					sum += d * d;
					n = Convert.ToInt32(sum);
				}
				if (eLoop.Contains(sum))
					return false;
				eLoop.Add(sum);
			}
		}

		return sum == 1;
	}

	// Single Number
	public static int SingleNumber(int[] nums)
	{
		Array.Sort(nums);
		int len = nums.Length;

		if (len > 1)
		{
			if (nums[0] != nums[1]) return nums[0]; // first num
			if (nums[len - 1] != nums[len - 2]) return nums[len - 1]; // last num
			for (int i = 1; i < len - 1; i++) //one of the interrior nums
			{
				if (nums[i] != nums[i - 1] && nums[i] != nums[i + 1]) return nums[i];
			}
		}

		return nums[0];
	}

	// Move Zeroes
	public static void MoveZeroes(int[] nums)
	{
		int pos = 0;
		int len = nums.Length;
		if (len > 1)
		{
			for (int i = 0; i < len; i++)
			{
				if (nums[i] != 0)
				{
					int t = nums[i];
					nums[i] = nums[pos];
					nums[pos] = t;
					pos++;
				}
			}
		}
	}

}