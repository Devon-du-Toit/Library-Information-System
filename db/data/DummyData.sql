-- =========================================
-- INSERT DUMMY DATA FOR library_db
-- =========================================

-- SUBJECTS
INSERT INTO SUBJECT (Subject_Name, Subject_Description) VALUES
('Mathematics', 'Numbers, algebra, geometry and calculus'),
('Physics', 'Study of matter, energy and forces'),
('Computer Science', 'Programming, algorithms and systems'),
('History', 'Events and civilizations over time'),
('Biology', 'Living organisms and ecosystems');

-- AUTHORS
INSERT INTO AUTHOR (Author_Name, Author_LastName) VALUES
('Isaac', 'Newton'),
('Alan', 'Turing'),
('Albert', 'Einstein'),
('Charles', 'Darwin'),
('Ada', 'Lovelace');

-- LIBRARY STAFF
INSERT INTO LIBRARY_STAFF (First_Name, Last_Name, Email, Contact_Number, Username, Password, Role) VALUES
('Alice', 'Smith', 'alice.smith@library.com', '1234567890', 'asmith', 'pass123', 'ADMIN'),
('Bob', 'Johnson', 'bob.johnson@library.com', '2345678901', 'bjohnson', 'pass456', 'STAFF'),
('Carol', 'Miller', 'carol.miller@library.com', '3456789012', 'cmiller', 'pass789', 'STAFF');

-- DONORS
INSERT INTO DONOR (First_Name, Contact_Number, Email) VALUES
('David', '4567890123', 'david.donor@email.com'),
('Emma', '5678901234', 'emma.donor@email.com'),
('Frank', '6789012345', 'frank.donor@email.com');

-- BORROWERS
INSERT INTO BORROWER (First_Name, Last_Name, Email, Contact_Number) VALUES
('George', 'Brown', 'george.brown@email.com', '7890123456'),
('Hannah', 'Wilson', 'hannah.wilson@email.com', '8901234567'),
('Ian', 'Taylor', 'ian.taylor@email.com', '9012345678');

-- TEXTBOOKS
INSERT INTO TEXTBOOK (Subject_ID, Author_ID, Title, ISBN, Edition, Publish_Year, Status) VALUES
(1, 1, 'Calculus for Beginners', '9780000000001', 2, '2015-01-01', TRUE),
(2, 3, 'Relativity Explained', '9780000000002', 1, '2010-01-01', TRUE),
(3, 2, 'Foundations of Computing', '9780000000003', 3, '2018-01-01', TRUE),
(4, 5, 'History of Algorithms', '9780000000004', 1, '2020-01-01', TRUE),
(5, 4, 'Theory of Evolution', '9780000000005', 5, '2005-01-01', TRUE);

-- BORROWS
INSERT INTO BORROW (Staff_ID, Borrower_ID, Date_Out, Date_Due, Date_In) VALUES
(2, 1, '2023-01-10', '2023-01-24', '2023-01-20'),
(3, 2, '2023-02-01', '2023-02-15', NULL),
(2, 3, '2023-03-05', '2023-03-19', '2023-03-18');

-- BORROW_BOOKS
INSERT INTO BORROW_BOOKS (Borrow_ID, Textbook_ID) VALUES
(1, 1),
(1, 2),
(2, 3),
(2, 4),
(3, 5);

-- DONATIONS
INSERT INTO DONATION (Staff_ID, Donor_ID, Date, Type, Amount) VALUES
(1, 1, '2023-04-01', 'Cash', 500.00),
(2, 2, '2023-05-15', 'Books', NULL),
(3, 3, '2023-06-20', 'Cash', 250.00);
