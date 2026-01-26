-- Database Setup Script for PersonalWebsite
-- Run this in MySQL Workbench

-- Create database if it doesn't exist
CREATE DATABASE IF NOT EXISTS PersonalWebsiteDb;

-- Use the database
USE PersonalWebsiteDb;

-- Create Comments table
CREATE TABLE IF NOT EXISTS Comments (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Username VARCHAR(100) NOT NULL,
    Message TEXT NOT NULL,
    CreatedDate DATETIME NOT NULL,
    SessionId VARCHAR(100) NULL,
    INDEX idx_created_date (CreatedDate),
    INDEX idx_username (Username)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Verify table was created
SELECT 'Database and table created successfully!' AS Status;
