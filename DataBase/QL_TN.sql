-- Tạo CSDL và sử dụng CSDL
CREATE DATABASE QL_TRAC_NGHIEM;
USE QL_TRAC_NGHIEM;

-- Tạo bảng và khóa chính
CREATE TABLE MON_HOC (
	MA_MON NVARCHAR(50) PRIMARY KEY,
	TEN_MON NVARCHAR(255),
);

CREATE TABLE TAI_KHOAN (
	MA_TK NVARCHAR(255) PRIMARY KEY,
	HO_TEN NVARCHAR(255),
	MAT_KHAU NVARCHAR(255),
	ROLE INT,
);

CREATE TABLE DE_THI (
	MA_DE_THI NVARCHAR(50) PRIMARY KEY,
	TEN_DE_THI NVARCHAR(255),
	MA_MON NVARCHAR(50),
	MA_TK NVARCHAR(255),
	THOI_LUONG INT,
	MAT_KHAU_DE NVARCHAR(255),
	TRANG_THAI INT,
);

CREATE TABLE CAU_HOI (
	MA_CAU_HOI NVARCHAR(50) PRIMARY KEY,
	MA_DE_THI NVARCHAR(50),
	NOI_DUNG NTEXT,
	PHUONG_AN_A NTEXT,
	PHUONG_AN_B NTEXT,
	PHUONG_AN_C NTEXT,
	PHUONG_AN_D NTEXT,
	DAP_AN NCHAR(1),
);

CREATE TABLE BAI_THI (
	MA_BAI_THI NVARCHAR(50) PRIMARY KEY,
	MA_DE_THI NVARCHAR(50),
	MA_TK NVARCHAR(255),
	THOI_GIAN_LAM SMALLDATETIME,
	DIEM FLOAT,
);

CREATE TABLE CHI_TIET_BAI_THI (
	MA_BAI_THI NVARCHAR(50),
	MA_CAU_HOI NVARCHAR(50),
	PHUONG_AN_CHON NCHAR(1),
	KET_QUA NVARCHAR(10),
	PRIMARY KEY (MA_BAI_THI, MA_CAU_HOI),
);

-- Tạo các ràng buộc khóa ngoại
ALTER TABLE DE_THI
ADD CONSTRAINT FK_DE_THI_MON_HOC
FOREIGN KEY (MA_MON) REFERENCES MON_HOC(MA_MON);

ALTER TABLE DE_THI
ADD CONSTRAINT FK_DE_THI_TAI_KHOAN
FOREIGN KEY (MA_TK) REFERENCES TAI_KHOAN(MA_TK);

ALTER TABLE CAU_HOI
ADD CONSTRAINT FK_CAU_HOI_DE_THI
FOREIGN KEY (MA_DE_THI) REFERENCES DE_THI(MA_DE_THI);

ALTER TABLE BAI_THI
ADD CONSTRAINT FK_BAI_THI_DE_THI
FOREIGN KEY (MA_DE_THI) REFERENCES DE_THI(MA_DE_THI);

ALTER TABLE BAI_THI
ADD CONSTRAINT FK_BAI_THI_TAI_KHOAN
FOREIGN KEY (MA_TK) REFERENCES TAI_KHOAN(MA_TK);

ALTER TABLE CHI_TIET_BAI_THI
ADD CONSTRAINT FK_CHI_TIET_BAI_THI_BAI_THI
FOREIGN KEY (MA_BAI_THI) REFERENCES BAI_THI(MA_BAI_THI);

ALTER TABLE CHI_TIET_BAI_THI
ADD CONSTRAINT FK_CHI_TIET_BAI_THI_CAU_HOI
FOREIGN KEY (MA_CAU_HOI) REFERENCES CAU_HOI(MA_CAU_HOI);

-- Nạp dữ liệu
INSERT INTO MON_HOC VALUES (N'TOAN', N'Toán');
INSERT INTO MON_HOC VALUES (N'VLY', N'Vật lý');
INSERT INTO MON_HOC VALUES (N'HHOC', N'Hóa học');
INSERT INTO MON_HOC VALUES (N'SHOC', N'Sinh học');
INSERT INTO MON_HOC VALUES (N'NVAN', N'Ngữ văn');
INSERT INTO MON_HOC VALUES (N'LSU', N'Lịch sử');
INSERT INTO MON_HOC VALUES (N'DLY', N'Địa lý');
INSERT INTO MON_HOC VALUES (N'TANH', N'Tiếng Anh');
INSERT INTO MON_HOC VALUES (N'THOC', N'Tin học');
INSERT INTO MON_HOC VALUES (N'GDKT-PL', N'Giáo dục kinh tế và pháp luật');

INSERT INTO TAI_KHOAN VALUES (N'admin', N'Admin', N'admin', 2);
INSERT INTO TAI_KHOAN VALUES (N'GV0001', N'Nguyễn Văn An', N'123456', 1);
INSERT INTO TAI_KHOAN VALUES (N'HS0001', N'Nguyễn Tuấn Anh', N'123456', 0);

-- SELECT dữ liệu
SELECT * FROM TAI_KHOAN;
SELECT * FROM MON_HOC;

SELECT * FROM DE_THI;
SELECT * FROM CAU_HOI;
SELECT * FROM BAI_THI;
SELECT * FROM CHI_TIET_BAI_THI;

-- TEST DATA cho môn Lích sử
-- Insert a test into DE_THI (History Exam)
INSERT INTO DE_THI VALUES (N'LSU001', N'Kiểm tra Lịch Sử 15 phút', N'LSU', N'GV0001', 15, 'a', 1);

-- Insert questions into CAU_HOI
INSERT INTO CAU_HOI VALUES 
(N'LSUQ001', N'LSU001', N'Ai là người phát hiện ra châu Mỹ?', N'Columbus', N'Magellan', N'Vasco da Gama', N'James Cook', N'A'),
(N'LSUQ002', N'LSU001', N'Năm 1945, sự kiện lịch sử quan trọng nào diễn ra ở Việt Nam?', N'Chiến dịch Điện Biên Phủ', N'Cách mạng tháng Tám', N'Tuyên ngôn độc lập', N'Hiệp định Genève', N'C'),
(N'LSUQ003', N'LSU001', N'Nước nào là đồng minh của Việt Nam trong kháng chiến chống Mỹ?', N'Liên Xô', N'Anh', N'Pháp', N'Nhật Bản', N'A'),
(N'LSUQ004', N'LSU001', N'Nhà Nguyễn thành lập vào năm nào?', N'1802', N'1858', N'1945', N'1975', N'A'),
(N'LSUQ005', N'LSU001', N'Chiến dịch nào kết thúc cuộc kháng chiến chống thực dân Pháp?', N'Chiến dịch Hồ Chí Minh', N'Chiến dịch Tây Nguyên', N'Chiến dịch Biên giới', N'Chiến dịch Điện Biên Phủ', N'D');

-- Insert an exam attempt into BAI_THI
INSERT INTO BAI_THI VALUES (N'BT001', N'LSU001', N'a', GETDATE(), 8.0);

-- Insert student's answers into CHI_TIET_BAI_THI
INSERT INTO CHI_TIET_BAI_THI VALUES 
(N'BT001', N'LSUQ001', N'A', N'Đúng'),
(N'BT001', N'LSUQ002', N'C', N'Đúng'),
(N'BT001', N'LSUQ003', N'B', N'Sai'),
(N'BT001', N'LSUQ004', N'A', N'Đúng'),
(N'BT001', N'LSUQ005', N'D', N'Đúng');

-- TEST DATA cho môn Tiếng Anh (TANH)
INSERT INTO DE_THI VALUES (N'TANH001', N'Kiểm tra Tiếng Anh 15 phút', N'TANH', N'GV0001', 15, 'b', 1);

INSERT INTO CAU_HOI VALUES 
(N'TANHQ001', N'TANH001', N'What is the capital of England?', N'Paris', N'London', N'Berlin', N'Rome', N'B'),
(N'TANHQ002', N'TANH001', N'Which word is a synonym for "happy"?', N'Sad', N'Angry', N'Joyful', N'Tired', N'C'),
(N'TANHQ003', N'TANH001', N'Choose the correct verb form: She ___ to music every day.', N'Listen', N'Listens', N'Listening', N'Listened', N'B'),
(N'TANHQ004', N'TANH001', N'What is the plural of "child"?', N'Childs', N'Children', N'Childes', N'Childi', N'B'),
(N'TANHQ005', N'TANH001', N'Complete the sentence: "I am ___ than you."', N'Tall', N'Taller', N'Tallest', N'More tall', N'B');

INSERT INTO BAI_THI VALUES (N'BT002', N'TANH001', N'HS0001', GETDATE(), 9.0);

INSERT INTO CHI_TIET_BAI_THI VALUES 
(N'BT002', N'TANHQ001', N'B', N'Đúng'),
(N'BT002', N'TANHQ002', N'C', N'Đúng'),
(N'BT002', N'TANHQ003', N'B', N'Đúng'),
(N'BT002', N'TANHQ004', N'B', N'Đúng'),
(N'BT002', N'TANHQ005', N'B', N'Đúng');

-- TEST DATA cho môn Tin học (THOC)
INSERT INTO DE_THI VALUES (N'THOC001', N'Kiểm tra Tin học 15 phút', N'THOC', N'GV0001', 15, 'c', 1);

INSERT INTO CAU_HOI VALUES 
(N'THOCQ001', N'THOC001', N'What does CPU stand for?', N'Computer Processing Unit', N'Central Processing Unit', N'Control Program Unit', N'Command Processing Unit', N'B'),
(N'THOCQ002', N'THOC001', N'Which programming language is used for web development?', N'Java', N'Python', N'HTML', N'C++', N'C'),
(N'THOCQ003', N'THOC001', N'What is RAM?', N'Read-only memory', N'Random access memory', N'Remote access memory', N'Registered access memory', N'B'),
(N'THOCQ004', N'THOC001', N'Which of the following is an operating system?', N'Microsoft Word', N'Google Chrome', N'Windows 10', N'Adobe Photoshop', N'C'),
(N'THOCQ005', N'THOC001', N'What is the function of a firewall?', N'To speed up the computer', N'To protect against viruses', N'To manage files', N'To connect to the internet', N'B');

INSERT INTO BAI_THI VALUES (N'BT003', N'THOC001', N'HS0001', GETDATE(), 7.0);

INSERT INTO CHI_TIET_BAI_THI VALUES 
(N'BT003', N'THOCQ001', N'B', N'Đúng'),
(N'BT003', N'THOCQ002', N'C', N'Đúng'),
(N'BT003', N'THOCQ003', N'A', N'Sai'),
(N'BT003', N'THOCQ004', N'C', N'Đúng'),
(N'BT003', N'THOCQ005', N'B', N'Đúng');

-- TEST DATA cho môn Sinh học (SHOC)
INSERT INTO DE_THI VALUES (N'SHOC001', N'Kiểm tra Sinh học 15 phút', N'SHOC', N'GV0001', 15, 'd', 1);

INSERT INTO CAU_HOI VALUES 
(N'SHOCQ001', N'SHOC001', N'What is the powerhouse of the cell?', N'Nucleus', N'Mitochondria', N'Endoplasmic reticulum', N'Golgi apparatus', N'B'),
(N'SHOCQ002', N'SHOC001', N'Which gas do plants absorb from the atmosphere?', N'Oxygen', N'Nitrogen', N'Carbon dioxide', N'Hydrogen', N'C'),
(N'SHOCQ003', N'SHOC001', N'What is the process by which plants make their own food?', N'Respiration', N'Photosynthesis', N'Digestion', N'Fermentation', N'B'),
(N'SHOCQ004', N'SHOC001', N'Which vitamin is essential for good vision?', N'Vitamin A', N'Vitamin C', N'Vitamin D', N'Vitamin E', N'A'),
(N'SHOCQ005', N'SHOC001', N'What is the main function of red blood cells?', N'To fight infections', N'To carry oxygen', N'To clot blood', N'To produce hormones', N'B');

INSERT INTO BAI_THI VALUES (N'BT004', N'SHOC001', N'HS0001', GETDATE(), 8.0);

INSERT INTO CHI_TIET_BAI_THI VALUES 
(N'BT004', N'SHOCQ001', N'B', N'Đúng'),
(N'BT004', N'SHOCQ002', N'C', N'Đúng'),
(N'BT004', N'SHOCQ003', N'B', N'Đúng'),
(N'BT004', N'SHOCQ004', N'D', N'Sai'),
(N'BT004', N'SHOCQ005', N'B', N'Đúng');

-- TEST DATA cho môn Ngữ văn (NVAN)
INSERT INTO DE_THI VALUES (N'NVAN001', N'Kiểm tra Ngữ văn 15 phút', N'NVAN', N'GV0001', 15, 'e', 1);

INSERT INTO CAU_HOI VALUES 
(N'NVANQ001', N'NVAN001', N'Ai là tác giả của truyện ngắn "Lão Hạc"?', N'Nam Cao', N'Tô Hoài', N'Ngô Tất Tố', N'Thạch Lam', N'A'),
(N'NVANQ002', N'NVAN001', N'Bài thơ "Tây Tiến" của tác giả nào?', N'Hồ Chí Minh', N'Tố Hữu', N'Quang Dũng', N'Xuân Diệu', N'C'),
(N'NVANQ003', N'NVAN001', N'Dòng nào sau đây là một thành ngữ?', N'Ăn quả nhớ kẻ trồng cây', N'Uống nước nhớ nguồn', N'Đi một ngày đàng học một sàng khôn', N'Tất cả các đáp án trên', N'D'),
(N'NVANQ004', N'NVAN001', N'Nhân vật Chí Phèo xuất hiện trong tác phẩm nào?', N'Số đỏ', N'Tắt đèn', N'Lão Hạc', N'Chí Phèo', N'D'),
(N'NVANQ005', N'NVAN001', N'Thể thơ nào có 5 chữ mỗi dòng?', N'Thơ lục bát', N'Thơ song thất lục bát', N'Thơ năm chữ', N'Thơ thất ngôn tứ tuyệt', N'C');

INSERT INTO BAI_THI VALUES (N'BT005', N'NVAN001', N'HS0001', GETDATE(), 6.0);

INSERT INTO CHI_TIET_BAI_THI VALUES 
(N'BT005', N'NVANQ001', N'A', N'Đúng'),
(N'BT005', N'NVANQ002', N'C', N'Đúng'),
(N'BT005', N'NVANQ003', N'B', N'Sai'),
(N'BT005', N'NVANQ004', N'A', N'Sai'),
(N'BT005', N'NVANQ005', N'C', N'Đúng');