# Vending Machine CLI Application

A beginner-friendly Vending Machine program written in Visual Basic .NET.  
This app lets you select an item by code, insert money, and receive the item in the console.

## Features

- Displays a welcome message to the user.
- Lists available vending machine items with names and prices.
- User interaction via the console.

## The Problem Statement

Create a simple console program that acts like a vending machine. When the program starts, it should show a list of items with codes and prices. The user can enter the code of the item they want to buy and then enter the amount of money they are putting in. If the user enters enough money, the program gives the item and shows any change. If the code is wrong or the money is not enough, the program should show a clear error message.

## File Overview

- **CLI.vb** – Handles all the messages and item display in the console.
- **Items.vb** – (Usually) defines what an item is (like its name and price).
- **Vending.vb** – (Usually) contains the logic for vending items.
- **UserInput.vb** – (Usually) handles what the user types in.
- **Program.vb** – The main entry point that starts the program.

## What You’ll See

When you run the program, you’ll see a welcome message and a list of items, each with a code, name, and price.  
You will then be asked to enter the code of the item you want to buy and the amount of money you are inserting.  
If you enter enough money, you’ll receive the item and any change. If you enter an invalid code or not enough money, you’ll see a clear error message.

Example:

<!-- Replace this with your actual console screenshot -->
![Console Screenshot](https://media.discordapp.net/attachments/1395234122644983898/1395234136205295767/image.png?ex=6879b48c&is=6878630c&hm=dc9ff38991a8b4122d60aefba1835a0a8967670648a657ab8820a8a1c4920140&=&format=webp&quality=lossless)
