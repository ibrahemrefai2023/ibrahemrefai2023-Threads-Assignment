# Assignment 05 — Answers

Student name:  Ibrahem Salah Refai
Group / ID: 3

## Failures you observed
1- System.InvalidOperationException: Operations that change non-concurrent collections must have exclusive access. A concurrent update was performed on this collection and corrupted its state. The collection's state is no longer correct.
=> this exception is occure because there are many threads add same product in dictionary at same time .
2- System.IndexOutOfRangeException:  Index was outside the bounds of the array.
This exception occurs because multiple threads attempt to add orderId values to the Queue simultaneously.
Since Queue uses an internal array to store its elements and is not thread-safe,
concurrent calls to Enqueue() can cause race conditions and may lead to exceptions such as IndexOutOfRangeException.
3- System.InvalidOperationException: Queue empty.
This exception occurs because multiple threads attempt to Dequeue from EmailJobs  to the Queue simultaneously.
Since Queue uses an internal array to store its elements and is not thread-safe,
concurrent calls to Enqueue() can cause race conditions and may lead to exceptions such as InvalidOperationException.
## What you changed

- I used the lock keyword to prevent multiple threads from accessing the email job and view operations simultaneously.

## Collection safety vs business-rule safety

- We cannot rely on making a collection thread-safe alone to ensure the entire operation is thread-safe,
  because other code, such as conditions (if-else statements) and related operations,
  must also be protected to maintain business-rule consistency.
