# Assignment 04 — Answers

Student name:  Ibrahem Salah Refai
Group / ID: 3

## Why Expected and Actual disagree

-Multiple threads can access the RegisterView method simultaneously and update the view count at the same time, which can lead to race conditions and cause the actual result to differ from the expected result.

## What you changed

-I fixed this problem by using the lock keyword to prevent multiple threads from accessing the critical section inside the RegisterView method simultaneously, ensuring that only one thread can execute it at a time.

## When would you protect the update differently

-I will use Interlocked.Increment() if i want to protect this kind of update differently .
