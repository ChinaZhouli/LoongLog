﻿using LoongLogger;
using System;

namespace LoongLog
{
    class Program
    {
        // https://github.com/loongEgg/LoongLog
        static void Main(string[] args) {

            // 02.
            ConsoleLogger logger = new ConsoleLogger();
            logger.WriteLine();

            // 01.
            // ColorfullConsoleAndTimeFormat();
             
            Console.ReadKey();// 暂停的一种方法
        }

        // TODO: 01-A 彩色的控制台输出           
        // TODO: 01-B 时间的格式化输出

        /// <summary>
        /// 01. 控制台的彩色输出和时间格式化
        /// </summary>
        static void ColorfullConsoleAndTimeFormat() {
            // 获取当前颜色（默认颜色）
            var oldColor = Console.ForegroundColor;

            // 输出一次蓝色
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("This is blue...");
            
            // 输出一次红色
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("This is red...");

            // 输出一次黄色
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("This is yellow...");
            
            // 将控制台设置为默认
            Console.ForegroundColor = oldColor;
            Console.WriteLine("This is default...");

            // 获取当前时间
            var time = DateTime.Now;
            Console.WriteLine($"Normal format: {time.ToString()}");

            // 时间的格式化
            Console.WriteLine($"Format string: {time.ToString("yyyy-MM-dd hh-mm-ss")}");
        }

    }
}
