create database hospital;

create table doctor (
doc_id int(5)  auto_increment primary key,
major_treat varchar(25) not null,
doc_name varchar(20) not null,
doc_gen varchar(2) not null,
doc_phone varchar(15) not null,
doc_email varchar(50) null);

create table diagnosis (
treat_id int(255)  auto_increment primary key,
doc_name varchar(20) not null,
pat_name  varchar(20) not null,
treat_contents text not null,
treat_date date not null
);

create table patient (
pat_id int(255)  auto_increment primary key,
pat_addr varchar(100) not null,
pat_name varchar(20) not null,
pat_gen varchar(2) not null,
pat_phone varchar(15) not null,
pat_email varchar(50) null,
major_treat varchar(25) not null,
doc_name varchar(20) not null,
nur_name  varchar(20) not null
);

create table nurse (
nur_id int(5)  auto_increment primary key,
major_job varchar(25) not null,
nur_name varchar(20) not null,
nur_gen varchar(2) not null,
nur_phone varchar(15) not null,
nur_email varchar(50) null);

