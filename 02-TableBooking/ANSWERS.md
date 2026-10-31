# Assignment 02 — Answers

Student name:  Ibrahem Salah Refai
Group / ID: 3

## What Was Wrong

- The FridayNightBooking method was not thread-safe because multiple threads could access it simultaneously check TablesLeft, decrease TablesLeft, and increase Booked at the same time potentially causing race conditions.

## How I Fixed It

- I used a lock statement to make the FridayNightBooking method thread-safe and prevent multiple threads from executing the critical section simultaneously.
