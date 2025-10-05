-- Create database (if it doens't exist) and use it
CREATE DATABASE IF NOT EXISTS library_db;
-- Make this database the current schema for everything that follows
USE library_db;

/* CLEAN RE-RUN SAFETY 
   This block allows re-running the script during development.
   It drops child tables before parents to avoid FK errors.
   DO NOT run this in PRODUCTION as it drops data. */
SET FOREIGN_KEY_CHECKS = 0; -- Temporarily ignore FK constraints while dropping
DROP TABLE IF EXISTS BORROW_BOOKS;
DROP TABLE IF EXISTS BORROW;
DROP TABLE IF EXISTS DONATION;
DROP TABLE IF EXISTS TEXTBOOK;
DROP TABLE IF EXISTS BORROWER;
DROP TABLE IF EXISTS DONOR;
DROP TABLE IF EXISTS LIBRARY_STAFF;
DROP TABLE IF EXISTS AUTHOR;
DROP TABLE IF EXISTS SUBJECT;
SET FOREIGN_KEY_CHECKS = 1; -- Re-enable FK checks.

CREATE TABLE SUBJECT (
  Subject_ID        INT AUTO_INCREMENT PRIMARY KEY,
  Subject_Name      VARCHAR(35)  NOT NULL,
  Subject_Description VARCHAR(60) NULL
);

CREATE TABLE AUTHOR (
  Author_ID     INT AUTO_INCREMENT PRIMARY KEY,
  Author_Name   VARCHAR(35) NOT NULL,
  Author_LastName VARCHAR(60) NOT NULL
);

CREATE TABLE LIBRARY_STAFF (
  Staff_ID      INT AUTO_INCREMENT PRIMARY KEY,
  First_Name    VARCHAR(35) NOT NULL,
  Last_Name     VARCHAR(35) NOT NULL,
  Email         VARCHAR(35) NOT NULL,
  Contact_Number VARCHAR(10) NOT NULL,
  Username      VARCHAR(35) NOT NULL,
  Password      VARCHAR(35) NOT NULL, -- store a hash in real systems!!!
  Role          CHAR(5)      NOT NULL, 
  CONSTRAINT uq_staff_username UNIQUE (Username), -- prevent duplicates
  CONSTRAINT uq_staff_email    UNIQUE (Email)
);

CREATE TABLE DONOR (
  Donor_ID      INT AUTO_INCREMENT PRIMARY KEY,
  First_Name    VARCHAR(35) NOT NULL,
  Contact_Number VARCHAR(10) NOT NULL,
  Email         VARCHAR(35) NOT NULL,
  CONSTRAINT uq_donor_email UNIQUE (Email)
);

CREATE TABLE BORROWER (
  Borrower_ID    INT AUTO_INCREMENT PRIMARY KEY,
  First_Name     VARCHAR(35) NOT NULL,
  Last_Name      VARCHAR(35) NOT NULL,
  Email          VARCHAR(35) NOT NULL,
  Contact_Number VARCHAR(10) NOT NULL,
  CONSTRAINT uq_borrower_email UNIQUE (Email)
);

CREATE TABLE TEXTBOOK (
  TextBook_ID   INT AUTO_INCREMENT PRIMARY KEY,
  Subject_ID    INT NOT NULL,
  Author_ID     INT NOT NULL,
  Title         VARCHAR(35) NOT NULL,
  ISBN          VARCHAR(13) NOT NULL,
  Edition       INT         NULL,
  Publish_Year  DATETIME    NULL,
  Status        BOOLEAN     NOT NULL DEFAULT TRUE,  -- Available = TRUE
  CONSTRAINT fk_textbook_subject FOREIGN KEY (Subject_ID)
    REFERENCES SUBJECT (Subject_ID)
    ON UPDATE CASCADE ON DELETE RESTRICT,
  CONSTRAINT fk_textbook_author FOREIGN KEY (Author_ID)
    REFERENCES AUTHOR (Author_ID)
    ON UPDATE CASCADE ON DELETE RESTRICT,
  CONSTRAINT uq_textbook_isbn UNIQUE (ISBN)
);

CREATE TABLE BORROW (
  Borrow_ID     INT AUTO_INCREMENT PRIMARY KEY,
  Staff_ID      INT NOT NULL,
  Borrower_ID   INT NOT NULL,
  Date_Out      DATETIME NOT NULL,
  Date_Due      DATETIME NOT NULL,
  Date_In       DATETIME NULL,
  CONSTRAINT fk_borrow_staff FOREIGN KEY (Staff_ID)
    REFERENCES LIBRARY_STAFF (Staff_ID)
    ON UPDATE CASCADE ON DELETE RESTRICT,
  CONSTRAINT fk_borrow_borrower FOREIGN KEY (Borrower_ID)
    REFERENCES BORROWER (Borrower_ID)
    ON UPDATE CASCADE ON DELETE RESTRICT
);

CREATE TABLE BORROW_BOOKS (
  Borrow_ID    INT NOT NULL,
  Textbook_ID  INT NOT NULL,
  PRIMARY KEY (Borrow_ID, Textbook_ID),
  CONSTRAINT fk_bb_borrow FOREIGN KEY (Borrow_ID)
    REFERENCES BORROW (Borrow_ID)
    ON UPDATE CASCADE ON DELETE RESTRICT,
  CONSTRAINT fk_bb_textbook FOREIGN KEY (Textbook_ID)
    REFERENCES TEXTBOOK (TextBook_ID)
    ON UPDATE CASCADE ON DELETE RESTRICT
);

CREATE TABLE DONATION (
  Donation_ID  INT AUTO_INCREMENT PRIMARY KEY,
  Staff_ID     INT NOT NULL,
  Donor_ID     INT NOT NULL,
  Date         DATETIME NOT NULL,
  Type         VARCHAR(35) NOT NULL,
  Amount       DECIMAL(10,2) NULL, -- TODO: PERHAPS THIS SHOULD BE OF TYPE MONEY?????
  CONSTRAINT fk_donation_staff FOREIGN KEY (Staff_ID)
    REFERENCES LIBRARY_STAFF (Staff_ID)
    ON UPDATE CASCADE ON DELETE RESTRICT,
  CONSTRAINT fk_donation_donor FOREIGN KEY (Donor_ID)
    REFERENCES DONOR (Donor_ID)
    ON UPDATE CASCADE ON DELETE RESTRICT
);
