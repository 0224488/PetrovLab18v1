﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrovLab18_Collections
{
	class Program
	{
		// Дана строка, содержащая скобки трёх видов(круглые, квадратные и фигурные) и любые другие символы.
		// Проверить, корректно ли в ней расставлены скобки. 
		// Например, в строке ([]{ })[] скобки расставлены корректно, а в строке([]] — нет.
		// Указание: задача решается однократным проходом по символам заданной строки слева направо; 
		// для каждой открывающей скобки в строке в стек помещается соответствующая закрывающая, 
		// каждая закрывающая скобка в строке должна соответствовать скобке из вершины стека
		// (при этом скобка с вершины стека снимается); в конце прохода стек должен быть пуст.

		static void Main(string[] args)
		{
			Console.WriteLine("Введите строку, содержащую скобки трёх видов(круглые, квадратные и фигурные) и любые другие символы");
			string text = Console.ReadLine();
			Stack<char> stack = new Stack<char>(); // Стек для "хранения скобок"...
			for (int i = 0; i < text.Length; i++)
			{
				switch (text[i])
				{
					case '(':
						stack.Push(')');    // Помещаем закрывающую скобку в стек
						break;
					case '[':
						stack.Push(']');    // Помещаем закрывающую скобку в стек
						break;
					case '{':
						stack.Push('}');    // Помещаем закрывающую скобку в стек
						break;
					case ')':
					case ']':
					case '}':
						{
							if (stack.Peek() == text[i]) // Снимаем скобку с вершины стека при ее совпадение
								stack.Pop();
						}
						break;
				}
			}
			Console.WriteLine($"Скобки расставлены {(stack.Count == 0 ? "корректно" : "не корректно")}");
			Console.ReadKey();
		}
	}
}
