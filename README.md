# 📱 Habit & Task Collaboration App

A productivity-focused mobile application that helps users build habits, manage tasks, and collaborate with friends using shared task groups, progress tracking, and Pomodoro sessions.

The app combines **habit tracking**, **task management**, **social comparison**, and **focused work sessions** into a single system designed to motivate consistency and accountability.

---

## 🚀 Features

### 👤 User & Social System
- User accounts with profile customization
- Friend system (send, accept, and manage friendships)
- Compare progress and achievements with friends

### 🧠 Habits
- Create habits with scheduled days (weekly frequency)
- Track daily habit completions
- Detect **perfect days** (all scheduled habits completed)
- Habit streak tracking
- Daily, weekly, monthly, and yearly statistics

### ✅ Tasks & Task Groups
- Personal tasks and shared tasks
- Task groups with custom title, icon, and color
- Invite friends to collaborate on tasks
- Track task completion and progress percentage

### 📊 Collaborative Progress Tracking
- Progress bar history with **user-based contributions**
- Visual progress segments colored by contributor
- See who updated progress and when

### ⏱ Pomodoro Sessions
- Pomodoro sessions per task
- Independent Pomodoro tracking per user on shared tasks
- Aggregate Pomodoro statistics per task, group, and user

### 📈 Statistics & Analytics
- Daily, weekly, monthly, and yearly statistics
- Habits completed
- Tasks completed
- Pomodoro sessions completed
- Perfect day counts
- Friend comparison via derived statistics

---

## 🏗️ Architecture Overview

- **Frontend:** React Native with Expo Sdk
- **Backend:** C#, EntityFramework, IdentityFramework
- **Database:** PostgreSQL
- **Authentication:** Bearer token
- **Real-time updates (optional):** [e.g., WebSockets / SignalR] ? !FIX!

The system is designed using:
- Normalized relational schema
- Event-based tracking for task progress
- Derived statistics (no duplicated data)
- Clear separation between state and history

---

## 🗄️ Database Design

The database schema follows best practices:
- Event tables for tracking history (progress updates, Pomodoro sessions)
- Aggregated statistics tables for performance
- No duplication of derived data
- Clear ownership and permissions through group membership

### 📷 Database Schema Diagram

<img width="1262" height="733" alt="image" src="https://github.com/user-attachments/assets/bdd888ed-e250-4587-8a8c-f64a160d5dcd" />

