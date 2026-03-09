# Flappy Bat

A small 2D micro-game developed in **Unity (C#)** as part of a personal challenge to create **10 micro-games to learn game development**.

The goal is to keep the scope extremely small and finish the game quickly.

---

# 🎮 Game Concept

**Flappy Bat** is a simple arcade game inspired by Flappy Bird.

The player controls a **bat** flying automatically inside a cave.  
By pressing a button, the bat flaps its wings and gains altitude. The player must avoid **stalactites and stalagmites** that form narrow gaps.

Each obstacle successfully passed increases the player's score.

Matches are short and skill-based.

---

# 🕹 Core Mechanics

The core mechanic is **vertical impulse flight**.

How it works:

- The bat is affected by **constant gravity**
- Pressing the action button gives the bat an **upward impulse**
- Obstacles appear from the right side and move to the left
- The player must keep the bat within the safe gap between obstacles

Main gameplay elements:

- Gravity
- Flap impulse
- Obstacle spawning
- Collision detection
- Scoring system

---

# 🎯 Controls

| Action | Control |
|------|------|
Flap | Mouse Click / Spacebar |
Restart | R |

Possible future support:

- Screen tap (mobile)

---

# 🔁 Gameplay Loop

Match flow:

1. Player starts the game
2. The bat begins to fall due to gravity
3. Player presses the button to flap upward
4. Obstacles spawn continuously
5. Player navigates through the gaps
6. Score increases
7. Collision occurs
8. Game Over
9. Player can restart

Summary:

Start → Fly → Avoid Obstacles → Gain Points → Collision → Game Over → Restart

---

# 🧮 Scoring Rules

Simple scoring system:

- **+1 point** for each obstacle passed

Suggested implementation:

- An **invisible trigger collider** placed between obstacles
- When the bat passes through the trigger, the score increases

---

# 💀 Lose Condition

The player loses when:

- The bat collides with an obstacle
- The bat hits the ground
- (Optional) The bat hits the ceiling

When losing:

- Gameplay stops
- A **Game Over** message appears
- The player can restart the game

---

# 🚧 Minimum Scope (MVP)

The MVP should include only the essential elements.

### Player

- Simple bat sprite
- Gravity
- Flap impulse when pressing the action button

### Obstacles

- Infinite obstacle generation
- Constant leftward movement

### Collision

- Bat vs obstacle collision detection

### Scoring

- Simple score counter on screen

### Minimal UI

- Score display
- Game Over message
- Restart option

**Important:**  
Avoid adding extra features to the MVP.

---

# 📋 Task List (≈1 hour sessions)

## Initial Setup

- Create Unity 2D project
- Create main scene
- Import placeholder bat sprite

---

## Player

- Create Player GameObject
- Add Rigidbody2D
- Configure gravity
- Implement flap impulse
- Adjust bat rotation

---

## Obstacles

- Create obstacle prefab (top + bottom)
- Create script to move obstacles left
- Create obstacle spawner
- Randomize gap height

---

## Collision

- Detect collision with obstacles
- Implement Game Over logic

---

## Scoring

- Create score trigger
- Implement score counter
- Display score in UI

---

## Interface

- Create Game Over text
- Implement restart key

---

## Minimal Polish

- Adjust game speed
- Adjust obstacle spacing
- Balance basic difficulty

---

# 🎨 Art Suggestions

Use simple placeholder art for the MVP.

### Bat

- Simple pixel art sprite
- Or even a basic shape placeholder

### Obstacles

- Rectangles representing cave rocks

### Background

- Solid color
- Or a simple cave image

Possible sources for free assets:

- Kenney Assets
- itch.io free assets

---

# 🔊 Sound Suggestions

Simple sound effects are enough.

| Event | Sound |
|------|------|
Flap | Wing flap |
Score | Short beep |
Collision | Impact sound |

Free sound sources:

- Freesound
- Kenney

---

# 🚀 Possible Future Improvements (Not part of MVP)

Ideas for future versions:

### Visual

- Wing flap animation
- Parallax background
- Particle effects

### Gameplay

- Increasing speed over time
- Moving obstacles
- Collectible coins

### Progression

- High score system
- Achievement medals

### Content

- Bat skins
- Different cave themes

### Mobile

- Touch controls
- Android build

---

# ✅ Completion Criteria

The micro-game is considered **finished** when:

- The bat can fly
- Obstacles spawn
- Collision works
- Score system works
- Game Over works
- Restart works

Even if the art is temporary.

The main goal is to **finish the game quickly and move on to the next micro-game in the challenge**.
