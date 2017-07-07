﻿CREATE TABLE [dbo].[one_time_payment] (
    [employee_key]            INT           NOT NULL,
    [current_position_key]    INT           NOT NULL,
    [position_key]            INT           NOT NULL,
    [suffix]                  VARCHAR (50)  NULL,
    [job_status]              VARCHAR (50)  NULL,
    [effective_date]          DATETIME      NULL,
    [job_change_reason_other] VARCHAR (250) NULL,
    [personnel_date]          DATETIME      NULL,
    [salary]                  MONEY         CONSTRAINT [DF_one_time_payment_salary] DEFAULT ((0)) NULL,
    [rate]                    INT           CONSTRAINT [DF_one_time_payment_rate] DEFAULT ((1)) NOT NULL,
    [hours_per_pay_period]    INT           CONSTRAINT [DF_one_time_payment_hours_per_pay_period] DEFAULT ((0)) NOT NULL,
    [factor]                  INT           CONSTRAINT [DF_one_time_payment_factor] DEFAULT ((0)) NOT NULL,
    [index_key]               INT           NOT NULL,
    [account_key]             INT           NOT NULL,
    [fund]                    VARCHAR (50)  NULL,
    [percent]                 NUMERIC (18)  NULL,
    [created]                 DATETIME      CONSTRAINT [DF_one_time_payment_created] DEFAULT (getdate()) NOT NULL,
    [created_by]              INT           NOT NULL,
    [modified]                DATETIME      NOT NULL,
    [modified_by]             INT           NOT NULL,
    [comment]                 VARCHAR (255) NULL,
    [supervisor_name]         VARCHAR (80)  NULL,
    [job_change_reason_key]   INT           NULL,
    [payroll_key]             INT           NULL,
    [dept_key]                INT           NULL,
    [approval_status_key]     INT           DEFAULT ((0)) NULL,
    [one_time_payment_key]    INT           IDENTITY (1, 1) NOT NULL
);

