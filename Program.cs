﻿#nullable disable
using ConsoleApp;

Console.Clear();

int[] nums = {10, 70, 30, 100, 40, 45, 90, 80, 85};
string[] words = {"dog","at", "good", "eye", "cat", "ball", "fish"};
 
Console.WriteLine("Bubble Sort\n---");
Sort.bubble(nums);
Sort.bubble(words);

// Console.WriteLine("Selection Sort\n---");
// Sort.selection(nums);
// Sort.selection(words);

Utility.writeAll(nums);
Utility.writeAll(words);