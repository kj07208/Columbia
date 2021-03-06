﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BTRServices.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class BtrDbContext : DbContext
    {
        public BtrDbContext()
            : base("name=BtrDbContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<account> accounts { get; set; }
        public virtual DbSet<approval_status> approval_status { get; set; }
        public virtual DbSet<department> departments { get; set; }
        public virtual DbSet<index> indices { get; set; }
        public virtual DbSet<job> jobs { get; set; }
        public virtual DbSet<program> programs { get; set; }
        public virtual DbSet<responsibility_matrix> responsibility_matrix { get; set; }
        public virtual DbSet<status> status { get; set; }
        public virtual DbSet<available_balances> available_balances { get; set; }
        public virtual DbSet<budget_transfer_request> budget_transfer_request { get; set; }
        public virtual DbSet<user> users { get; set; }
        public virtual DbSet<xref_budget_type> xref_budget_type { get; set; }
        public virtual DbSet<xref_internal_state> xref_internal_state { get; set; }
        public virtual DbSet<xref_life_cycle> xref_life_cycle { get; set; }
        public virtual DbSet<Audit> Audits { get; set; }
        public virtual DbSet<vw_budget_transfer_request_records> vw_budget_transfer_request_records { get; set; }
        public virtual DbSet<xref_transfer_type> xref_transfer_type { get; set; }
        public virtual DbSet<transfer_activity> transfer_activity { get; set; }
        public virtual DbSet<xref_position_type> xref_position_type { get; set; }
        public virtual DbSet<vw_transfer_activities_datarecords> vw_transfer_activities_datarecords { get; set; }
        public virtual DbSet<approval_matrix> approval_matrix { get; set; }
        public virtual DbSet<xref_approval_status> xref_approval_status { get; set; }
        public virtual DbSet<xref_job_change_reason> xref_job_change_reason { get; set; }
        public virtual DbSet<xref_position> xref_position { get; set; }
        public virtual DbSet<transfer_activity_reviewers> transfer_activity_reviewers { get; set; }
        public virtual DbSet<v_Transfer_Activity_Create_JV> v_Transfer_Activity_Create_JV { get; set; }
        public virtual DbSet<vw_Accounts> vw_Accounts { get; set; }
        public virtual DbSet<vw_Indices> vw_Indices { get; set; }
        public virtual DbSet<vw_Indices_lk_all> vw_Indices_lk_all { get; set; }
        public virtual DbSet<vw_Indices_lk_byowner> vw_Indices_lk_byowner { get; set; }
        public virtual DbSet<vw_lk_accounts> vw_lk_accounts { get; set; }
        public virtual DbSet<vw_transfer_activities_datarecord> vw_transfer_activities_datarecord { get; set; }
        public virtual DbSet<database_firewall_rules> database_firewall_rules { get; set; }
        public virtual DbSet<vw_transfer_activities_reviewers> vw_transfer_activities_reviewers { get; set; }
    
        public virtual ObjectResult<account_byId_Result> account_byId(Nullable<int> account_key)
        {
            var account_keyParameter = account_key.HasValue ?
                new ObjectParameter("account_key", account_key) :
                new ObjectParameter("account_key", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<account_byId_Result>("account_byId", account_keyParameter);
        }
    
        public virtual ObjectResult<account_byIndex_Result> account_byIndex(Nullable<int> index_key)
        {
            var index_keyParameter = index_key.HasValue ?
                new ObjectParameter("index_key", index_key) :
                new ObjectParameter("index_key", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<account_byIndex_Result>("account_byIndex", index_keyParameter);
        }
    
        public virtual ObjectResult<accountbalance_byaccountkey_Result> accountbalance_byaccountkey(Nullable<int> account_key)
        {
            var account_keyParameter = account_key.HasValue ?
                new ObjectParameter("account_key", account_key) :
                new ObjectParameter("account_key", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<accountbalance_byaccountkey_Result>("accountbalance_byaccountkey", account_keyParameter);
        }
    
        public virtual ObjectResult<accountbalance_byaccountkey_Result> accountbalances_byindexkeys(string indexKeys)
        {
            var indexKeysParameter = indexKeys != null ?
                new ObjectParameter("indexKeys", indexKeys) :
                new ObjectParameter("indexKeys", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<accountbalance_byaccountkey_Result>("accountbalances_byindexkeys", indexKeysParameter);
        }
    
        public virtual ObjectResult<accounts_all_Result> accounts_all()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<accounts_all_Result>("accounts_all");
        }
    
        public virtual ObjectResult<approval_matrix_all_approvers_Result> approval_matrix_all_approvers(Nullable<int> index_key)
        {
            var index_keyParameter = index_key.HasValue ?
                new ObjectParameter("index_key", index_key) :
                new ObjectParameter("index_key", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<approval_matrix_all_approvers_Result>("approval_matrix_all_approvers", index_keyParameter);
        }
    
        public virtual ObjectResult<approval_matrix_approver_Result> approval_matrix_approver(Nullable<int> index_key, string role_level)
        {
            var index_keyParameter = index_key.HasValue ?
                new ObjectParameter("index_key", index_key) :
                new ObjectParameter("index_key", typeof(int));
    
            var role_levelParameter = role_level != null ?
                new ObjectParameter("role_level", role_level) :
                new ObjectParameter("role_level", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<approval_matrix_approver_Result>("approval_matrix_approver", index_keyParameter, role_levelParameter);
        }
    
        public virtual ObjectResult<indices_all_Result> indices_all()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<indices_all_Result>("indices_all");
        }
    
        public virtual ObjectResult<indices_bydept_Result> indices_bydept(Nullable<int> dept)
        {
            var deptParameter = dept.HasValue ?
                new ObjectParameter("dept", dept) :
                new ObjectParameter("dept", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<indices_bydept_Result>("indices_bydept", deptParameter);
        }
    
        public virtual ObjectResult<indices_byowner_Result> indices_byowner(string uni)
        {
            var uniParameter = uni != null ?
                new ObjectParameter("uni", uni) :
                new ObjectParameter("uni", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<indices_byowner_Result>("indices_byowner", uniParameter);
        }
    
        public virtual ObjectResult<indices_owned_bydept_Result> indices_owned_bydept(Nullable<int> dept, string uni)
        {
            var deptParameter = dept.HasValue ?
                new ObjectParameter("dept", dept) :
                new ObjectParameter("dept", typeof(int));
    
            var uniParameter = uni != null ?
                new ObjectParameter("uni", uni) :
                new ObjectParameter("uni", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<indices_owned_bydept_Result>("indices_owned_bydept", deptParameter, uniParameter);
        }
    
        public virtual ObjectResult<budget_transfer_request_datarecord_Result> budget_transfer_request_datarecord(Nullable<int> btr_key)
        {
            var btr_keyParameter = btr_key.HasValue ?
                new ObjectParameter("btr_key", btr_key) :
                new ObjectParameter("btr_key", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<budget_transfer_request_datarecord_Result>("budget_transfer_request_datarecord", btr_keyParameter);
        }
    
        public virtual int budget_transfer_request_display(Nullable<int> btr_key)
        {
            var btr_keyParameter = btr_key.HasValue ?
                new ObjectParameter("btr_key", btr_key) :
                new ObjectParameter("btr_key", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("budget_transfer_request_display", btr_keyParameter);
        }
    
        public virtual ObjectResult<budget_transfer_request_datarecords_Result> budget_transfer_request_datarecords()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<budget_transfer_request_datarecords_Result>("budget_transfer_request_datarecords");
        }
    
        public virtual ObjectResult<budget_transfer_request_create_Result> budget_transfer_request_create(string title, Nullable<int> budget_type_key, Nullable<decimal> total_amount, string explanation, Nullable<int> requestor_uni_key, Nullable<int> transfer_type_key, Nullable<int> life_cycle_key, Nullable<int> created_by)
        {
            var titleParameter = title != null ?
                new ObjectParameter("title", title) :
                new ObjectParameter("title", typeof(string));
    
            var budget_type_keyParameter = budget_type_key.HasValue ?
                new ObjectParameter("budget_type_key", budget_type_key) :
                new ObjectParameter("budget_type_key", typeof(int));
    
            var total_amountParameter = total_amount.HasValue ?
                new ObjectParameter("total_amount", total_amount) :
                new ObjectParameter("total_amount", typeof(decimal));
    
            var explanationParameter = explanation != null ?
                new ObjectParameter("explanation", explanation) :
                new ObjectParameter("explanation", typeof(string));
    
            var requestor_uni_keyParameter = requestor_uni_key.HasValue ?
                new ObjectParameter("requestor_uni_key", requestor_uni_key) :
                new ObjectParameter("requestor_uni_key", typeof(int));
    
            var transfer_type_keyParameter = transfer_type_key.HasValue ?
                new ObjectParameter("transfer_type_key", transfer_type_key) :
                new ObjectParameter("transfer_type_key", typeof(int));
    
            var life_cycle_keyParameter = life_cycle_key.HasValue ?
                new ObjectParameter("life_cycle_key", life_cycle_key) :
                new ObjectParameter("life_cycle_key", typeof(int));
    
            var created_byParameter = created_by.HasValue ?
                new ObjectParameter("created_by", created_by) :
                new ObjectParameter("created_by", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<budget_transfer_request_create_Result>("budget_transfer_request_create", titleParameter, budget_type_keyParameter, total_amountParameter, explanationParameter, requestor_uni_keyParameter, transfer_type_keyParameter, life_cycle_keyParameter, created_byParameter);
        }
    
        public virtual ObjectResult<transfer_activity_create_Result> transfer_activity_create(Nullable<int> btr_key, Nullable<int> position_type_key, Nullable<int> index_key, Nullable<int> account_key, Nullable<decimal> amount, Nullable<int> created_by)
        {
            var btr_keyParameter = btr_key.HasValue ?
                new ObjectParameter("btr_key", btr_key) :
                new ObjectParameter("btr_key", typeof(int));
    
            var position_type_keyParameter = position_type_key.HasValue ?
                new ObjectParameter("position_type_key", position_type_key) :
                new ObjectParameter("position_type_key", typeof(int));
    
            var index_keyParameter = index_key.HasValue ?
                new ObjectParameter("index_key", index_key) :
                new ObjectParameter("index_key", typeof(int));
    
            var account_keyParameter = account_key.HasValue ?
                new ObjectParameter("account_key", account_key) :
                new ObjectParameter("account_key", typeof(int));
    
            var amountParameter = amount.HasValue ?
                new ObjectParameter("amount", amount) :
                new ObjectParameter("amount", typeof(decimal));
    
            var created_byParameter = created_by.HasValue ?
                new ObjectParameter("created_by", created_by) :
                new ObjectParameter("created_by", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<transfer_activity_create_Result>("transfer_activity_create", btr_keyParameter, position_type_keyParameter, index_keyParameter, account_keyParameter, amountParameter, created_byParameter);
        }
    
        public virtual int transfer_activity_delete(Nullable<int> transfer_activity_key)
        {
            var transfer_activity_keyParameter = transfer_activity_key.HasValue ?
                new ObjectParameter("transfer_activity_key", transfer_activity_key) :
                new ObjectParameter("transfer_activity_key", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("transfer_activity_delete", transfer_activity_keyParameter);
        }
    
        public virtual ObjectResult<transfer_activity_update_Result> transfer_activity_update(Nullable<int> transfer_activity_key, Nullable<int> index_key, Nullable<int> account_key, Nullable<decimal> amount, Nullable<int> modified_by)
        {
            var transfer_activity_keyParameter = transfer_activity_key.HasValue ?
                new ObjectParameter("transfer_activity_key", transfer_activity_key) :
                new ObjectParameter("transfer_activity_key", typeof(int));
    
            var index_keyParameter = index_key.HasValue ?
                new ObjectParameter("index_key", index_key) :
                new ObjectParameter("index_key", typeof(int));
    
            var account_keyParameter = account_key.HasValue ?
                new ObjectParameter("account_key", account_key) :
                new ObjectParameter("account_key", typeof(int));
    
            var amountParameter = amount.HasValue ?
                new ObjectParameter("amount", amount) :
                new ObjectParameter("amount", typeof(decimal));
    
            var modified_byParameter = modified_by.HasValue ?
                new ObjectParameter("modified_by", modified_by) :
                new ObjectParameter("modified_by", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<transfer_activity_update_Result>("transfer_activity_update", transfer_activity_keyParameter, index_keyParameter, account_keyParameter, amountParameter, modified_byParameter);
        }
    
        public virtual ObjectResult<budget_transfer_request_update_Result> budget_transfer_request_update(Nullable<int> btr_key, string title, Nullable<int> budget_type_key, Nullable<decimal> total_amount, string explanation, Nullable<int> requestor_uni_key, Nullable<int> transfer_type_key, Nullable<int> life_cycle_key, Nullable<int> modified_by)
        {
            var btr_keyParameter = btr_key.HasValue ?
                new ObjectParameter("btr_key", btr_key) :
                new ObjectParameter("btr_key", typeof(int));
    
            var titleParameter = title != null ?
                new ObjectParameter("title", title) :
                new ObjectParameter("title", typeof(string));
    
            var budget_type_keyParameter = budget_type_key.HasValue ?
                new ObjectParameter("budget_type_key", budget_type_key) :
                new ObjectParameter("budget_type_key", typeof(int));
    
            var total_amountParameter = total_amount.HasValue ?
                new ObjectParameter("total_amount", total_amount) :
                new ObjectParameter("total_amount", typeof(decimal));
    
            var explanationParameter = explanation != null ?
                new ObjectParameter("explanation", explanation) :
                new ObjectParameter("explanation", typeof(string));
    
            var requestor_uni_keyParameter = requestor_uni_key.HasValue ?
                new ObjectParameter("requestor_uni_key", requestor_uni_key) :
                new ObjectParameter("requestor_uni_key", typeof(int));
    
            var transfer_type_keyParameter = transfer_type_key.HasValue ?
                new ObjectParameter("transfer_type_key", transfer_type_key) :
                new ObjectParameter("transfer_type_key", typeof(int));
    
            var life_cycle_keyParameter = life_cycle_key.HasValue ?
                new ObjectParameter("life_cycle_key", life_cycle_key) :
                new ObjectParameter("life_cycle_key", typeof(int));
    
            var modified_byParameter = modified_by.HasValue ?
                new ObjectParameter("modified_by", modified_by) :
                new ObjectParameter("modified_by", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<budget_transfer_request_update_Result>("budget_transfer_request_update", btr_keyParameter, titleParameter, budget_type_keyParameter, total_amountParameter, explanationParameter, requestor_uni_keyParameter, transfer_type_keyParameter, life_cycle_keyParameter, modified_byParameter);
        }
    
        public virtual ObjectResult<transfer_activity_assign_reviewers_Result> transfer_activity_assign_reviewers(Nullable<int> transfer_activity_key, Nullable<int> approval_level, Nullable<System.Guid> workflow_guid)
        {
            var transfer_activity_keyParameter = transfer_activity_key.HasValue ?
                new ObjectParameter("transfer_activity_key", transfer_activity_key) :
                new ObjectParameter("transfer_activity_key", typeof(int));
    
            var approval_levelParameter = approval_level.HasValue ?
                new ObjectParameter("approval_level", approval_level) :
                new ObjectParameter("approval_level", typeof(int));
    
            var workflow_guidParameter = workflow_guid.HasValue ?
                new ObjectParameter("workflow_guid", workflow_guid) :
                new ObjectParameter("workflow_guid", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<transfer_activity_assign_reviewers_Result>("transfer_activity_assign_reviewers", transfer_activity_keyParameter, approval_levelParameter, workflow_guidParameter);
        }
    
        public virtual ObjectResult<transfer_activity_set_all_approval_levels_Result> transfer_activity_set_all_approval_levels(Nullable<int> btr_key, Nullable<int> approval_level)
        {
            var btr_keyParameter = btr_key.HasValue ?
                new ObjectParameter("btr_key", btr_key) :
                new ObjectParameter("btr_key", typeof(int));
    
            var approval_levelParameter = approval_level.HasValue ?
                new ObjectParameter("approval_level", approval_level) :
                new ObjectParameter("approval_level", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<transfer_activity_set_all_approval_levels_Result>("transfer_activity_set_all_approval_levels", btr_keyParameter, approval_levelParameter);
        }
    
        public virtual ObjectResult<transfer_activity_set_approval_level_Result> transfer_activity_set_approval_level(Nullable<int> transfer_activity_key, Nullable<int> approval_level)
        {
            var transfer_activity_keyParameter = transfer_activity_key.HasValue ?
                new ObjectParameter("transfer_activity_key", transfer_activity_key) :
                new ObjectParameter("transfer_activity_key", typeof(int));
    
            var approval_levelParameter = approval_level.HasValue ?
                new ObjectParameter("approval_level", approval_level) :
                new ObjectParameter("approval_level", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<transfer_activity_set_approval_level_Result>("transfer_activity_set_approval_level", transfer_activity_keyParameter, approval_levelParameter);
        }
    
        public virtual int one_time_payment_create_record(Nullable<int> employee_key, Nullable<int> current_position_key, Nullable<int> position_key, string suffix, string job_status, Nullable<System.DateTime> effective_date, Nullable<int> job_change_reason_key, string job_change_reason, Nullable<System.DateTime> personnel_date, Nullable<decimal> salary, Nullable<int> rate, Nullable<int> hours_per_pay_period, Nullable<int> factor, Nullable<int> index_key, Nullable<int> account_key, string fund, Nullable<decimal> percent, Nullable<int> created_by, Nullable<int> modified_by, string comment, string supervisor_name, Nullable<int> payroll_key, Nullable<int> dept_key)
        {
            var employee_keyParameter = employee_key.HasValue ?
                new ObjectParameter("employee_key", employee_key) :
                new ObjectParameter("employee_key", typeof(int));
    
            var current_position_keyParameter = current_position_key.HasValue ?
                new ObjectParameter("current_position_key", current_position_key) :
                new ObjectParameter("current_position_key", typeof(int));
    
            var position_keyParameter = position_key.HasValue ?
                new ObjectParameter("position_key", position_key) :
                new ObjectParameter("position_key", typeof(int));
    
            var suffixParameter = suffix != null ?
                new ObjectParameter("suffix", suffix) :
                new ObjectParameter("suffix", typeof(string));
    
            var job_statusParameter = job_status != null ?
                new ObjectParameter("job_status", job_status) :
                new ObjectParameter("job_status", typeof(string));
    
            var effective_dateParameter = effective_date.HasValue ?
                new ObjectParameter("effective_date", effective_date) :
                new ObjectParameter("effective_date", typeof(System.DateTime));
    
            var job_change_reason_keyParameter = job_change_reason_key.HasValue ?
                new ObjectParameter("job_change_reason_key", job_change_reason_key) :
                new ObjectParameter("job_change_reason_key", typeof(int));
    
            var job_change_reasonParameter = job_change_reason != null ?
                new ObjectParameter("job_change_reason", job_change_reason) :
                new ObjectParameter("job_change_reason", typeof(string));
    
            var personnel_dateParameter = personnel_date.HasValue ?
                new ObjectParameter("personnel_date", personnel_date) :
                new ObjectParameter("personnel_date", typeof(System.DateTime));
    
            var salaryParameter = salary.HasValue ?
                new ObjectParameter("salary", salary) :
                new ObjectParameter("salary", typeof(decimal));
    
            var rateParameter = rate.HasValue ?
                new ObjectParameter("rate", rate) :
                new ObjectParameter("rate", typeof(int));
    
            var hours_per_pay_periodParameter = hours_per_pay_period.HasValue ?
                new ObjectParameter("hours_per_pay_period", hours_per_pay_period) :
                new ObjectParameter("hours_per_pay_period", typeof(int));
    
            var factorParameter = factor.HasValue ?
                new ObjectParameter("factor", factor) :
                new ObjectParameter("factor", typeof(int));
    
            var index_keyParameter = index_key.HasValue ?
                new ObjectParameter("index_key", index_key) :
                new ObjectParameter("index_key", typeof(int));
    
            var account_keyParameter = account_key.HasValue ?
                new ObjectParameter("account_key", account_key) :
                new ObjectParameter("account_key", typeof(int));
    
            var fundParameter = fund != null ?
                new ObjectParameter("fund", fund) :
                new ObjectParameter("fund", typeof(string));
    
            var percentParameter = percent.HasValue ?
                new ObjectParameter("percent", percent) :
                new ObjectParameter("percent", typeof(decimal));
    
            var created_byParameter = created_by.HasValue ?
                new ObjectParameter("created_by", created_by) :
                new ObjectParameter("created_by", typeof(int));
    
            var modified_byParameter = modified_by.HasValue ?
                new ObjectParameter("modified_by", modified_by) :
                new ObjectParameter("modified_by", typeof(int));
    
            var commentParameter = comment != null ?
                new ObjectParameter("comment", comment) :
                new ObjectParameter("comment", typeof(string));
    
            var supervisor_nameParameter = supervisor_name != null ?
                new ObjectParameter("supervisor_name", supervisor_name) :
                new ObjectParameter("supervisor_name", typeof(string));
    
            var payroll_keyParameter = payroll_key.HasValue ?
                new ObjectParameter("payroll_key", payroll_key) :
                new ObjectParameter("payroll_key", typeof(int));
    
            var dept_keyParameter = dept_key.HasValue ?
                new ObjectParameter("dept_key", dept_key) :
                new ObjectParameter("dept_key", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("one_time_payment_create_record", employee_keyParameter, current_position_keyParameter, position_keyParameter, suffixParameter, job_statusParameter, effective_dateParameter, job_change_reason_keyParameter, job_change_reasonParameter, personnel_dateParameter, salaryParameter, rateParameter, hours_per_pay_periodParameter, factorParameter, index_keyParameter, account_keyParameter, fundParameter, percentParameter, created_byParameter, modified_byParameter, commentParameter, supervisor_nameParameter, payroll_keyParameter, dept_keyParameter);
        }
    
        public virtual ObjectResult<one_time_payment_read_record_Result> one_time_payment_read_record(Nullable<int> one_time_payment_key)
        {
            var one_time_payment_keyParameter = one_time_payment_key.HasValue ?
                new ObjectParameter("one_time_payment_key", one_time_payment_key) :
                new ObjectParameter("one_time_payment_key", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<one_time_payment_read_record_Result>("one_time_payment_read_record", one_time_payment_keyParameter);
        }
    
        public virtual ObjectResult<string> Create_JV(Nullable<int> btr_key, ObjectParameter jv_doc_id, ObjectParameter p_status_ind, ObjectParameter p_status_message)
        {
            var btr_keyParameter = btr_key.HasValue ?
                new ObjectParameter("btr_key", btr_key) :
                new ObjectParameter("btr_key", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("Create_JV", btr_keyParameter, jv_doc_id, p_status_ind, p_status_message);
        }
    
        public virtual int Get_Account_Available_Balance(string p_coas_code, string p_fund_code, string p_orgn_code, string p_acct_code, string p_prog_code, ObjectParameter available_balance)
        {
            var p_coas_codeParameter = p_coas_code != null ?
                new ObjectParameter("P_coas_code", p_coas_code) :
                new ObjectParameter("P_coas_code", typeof(string));
    
            var p_fund_codeParameter = p_fund_code != null ?
                new ObjectParameter("P_fund_code", p_fund_code) :
                new ObjectParameter("P_fund_code", typeof(string));
    
            var p_orgn_codeParameter = p_orgn_code != null ?
                new ObjectParameter("P_orgn_code", p_orgn_code) :
                new ObjectParameter("P_orgn_code", typeof(string));
    
            var p_acct_codeParameter = p_acct_code != null ?
                new ObjectParameter("P_acct_code", p_acct_code) :
                new ObjectParameter("P_acct_code", typeof(string));
    
            var p_prog_codeParameter = p_prog_code != null ?
                new ObjectParameter("P_prog_code", p_prog_code) :
                new ObjectParameter("P_prog_code", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Get_Account_Available_Balance", p_coas_codeParameter, p_fund_codeParameter, p_orgn_codeParameter, p_acct_codeParameter, p_prog_codeParameter, available_balance);
        }
    
        public virtual int Get_JV(ObjectParameter jv_doc_id)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Get_JV", jv_doc_id);
        }
    
        public virtual int mock_complete_jv(ObjectParameter jv_doc_id, string p_user_id_in, ObjectParameter p_status_ind, ObjectParameter p_status_message)
        {
            var p_user_id_inParameter = p_user_id_in != null ?
                new ObjectParameter("P_user_id_in", p_user_id_in) :
                new ObjectParameter("P_user_id_in", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("mock_complete_jv", jv_doc_id, p_user_id_inParameter, p_status_ind, p_status_message);
        }
    
        public virtual int mock_create_jv(ObjectParameter jv_doc_id, string p_acci_code, string p_coas_code, string p_fund_code, string p_orgn_code, string p_acct_code, string p_prog_code, string p_actv_code, string p_locn_code, string p_dr_cr_ind, Nullable<decimal> p_line_amt, Nullable<decimal> p_doc_total_amt, string p_change_type, string p_user_id_in, ObjectParameter p_status_ind, ObjectParameter p_status_message)
        {
            var p_acci_codeParameter = p_acci_code != null ?
                new ObjectParameter("P_acci_code", p_acci_code) :
                new ObjectParameter("P_acci_code", typeof(string));
    
            var p_coas_codeParameter = p_coas_code != null ?
                new ObjectParameter("P_coas_code", p_coas_code) :
                new ObjectParameter("P_coas_code", typeof(string));
    
            var p_fund_codeParameter = p_fund_code != null ?
                new ObjectParameter("P_fund_code", p_fund_code) :
                new ObjectParameter("P_fund_code", typeof(string));
    
            var p_orgn_codeParameter = p_orgn_code != null ?
                new ObjectParameter("P_orgn_code", p_orgn_code) :
                new ObjectParameter("P_orgn_code", typeof(string));
    
            var p_acct_codeParameter = p_acct_code != null ?
                new ObjectParameter("P_acct_code", p_acct_code) :
                new ObjectParameter("P_acct_code", typeof(string));
    
            var p_prog_codeParameter = p_prog_code != null ?
                new ObjectParameter("P_prog_code", p_prog_code) :
                new ObjectParameter("P_prog_code", typeof(string));
    
            var p_actv_codeParameter = p_actv_code != null ?
                new ObjectParameter("P_actv_code", p_actv_code) :
                new ObjectParameter("P_actv_code", typeof(string));
    
            var p_locn_codeParameter = p_locn_code != null ?
                new ObjectParameter("P_locn_code", p_locn_code) :
                new ObjectParameter("P_locn_code", typeof(string));
    
            var p_dr_cr_indParameter = p_dr_cr_ind != null ?
                new ObjectParameter("P_dr_cr_ind", p_dr_cr_ind) :
                new ObjectParameter("P_dr_cr_ind", typeof(string));
    
            var p_line_amtParameter = p_line_amt.HasValue ?
                new ObjectParameter("P_line_amt", p_line_amt) :
                new ObjectParameter("P_line_amt", typeof(decimal));
    
            var p_doc_total_amtParameter = p_doc_total_amt.HasValue ?
                new ObjectParameter("P_doc_total_amt", p_doc_total_amt) :
                new ObjectParameter("P_doc_total_amt", typeof(decimal));
    
            var p_change_typeParameter = p_change_type != null ?
                new ObjectParameter("P_change_type", p_change_type) :
                new ObjectParameter("P_change_type", typeof(string));
    
            var p_user_id_inParameter = p_user_id_in != null ?
                new ObjectParameter("P_user_id_in", p_user_id_in) :
                new ObjectParameter("P_user_id_in", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("mock_create_jv", jv_doc_id, p_acci_codeParameter, p_coas_codeParameter, p_fund_codeParameter, p_orgn_codeParameter, p_acct_codeParameter, p_prog_codeParameter, p_actv_codeParameter, p_locn_codeParameter, p_dr_cr_indParameter, p_line_amtParameter, p_doc_total_amtParameter, p_change_typeParameter, p_user_id_inParameter, p_status_ind, p_status_message);
        }
    
        public virtual int Budget_Transfer_Request_Complete(Nullable<int> btr_key, ObjectParameter jv_doc_id, ObjectParameter p_status_ind, ObjectParameter p_status_message)
        {
            var btr_keyParameter = btr_key.HasValue ?
                new ObjectParameter("btr_key", btr_key) :
                new ObjectParameter("btr_key", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Budget_Transfer_Request_Complete", btr_keyParameter, jv_doc_id, p_status_ind, p_status_message);
        }
    }
}
