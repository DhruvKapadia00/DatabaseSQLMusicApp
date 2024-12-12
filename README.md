Music App
Overview
The Music App is a Windows Forms (WinForms) application that enables users to manage a music database. The app currently allows users to add new albums and view existing albums along with their associated tracks. It uses MySQL as the backend database for storing and managing data. Additional features are planned for future updates.

Features
Current Functionality
Album Management:
Add new albums to the database.
View details of existing albums.
Track Management:
View tracks associated with each album.
Upcoming Features
Edit and delete albums.
Add, edit, and delete tracks.
Manage artist information.
Search and filter data by artist, genre, or release year.
Technology Stack
Frontend:
WinForms: Used for building the graphical user interface (GUI).
Backend:
MySQL: Database used for managing and storing application data.
Database Structure
The app uses a relational database schema with the following key tables:

Tables:
Albums:

album_id (Primary Key)
title
artist_id (Foreign Key referencing Artists)
release_date
genre
Tracks:

track_id (Primary Key)
title
album_id (Foreign Key referencing Albums)
duration
Artists:

artist_id (Primary Key)
name
bio
Relationships:
One-to-Many:
An artist can have many albums.
An album can have many tracks.
