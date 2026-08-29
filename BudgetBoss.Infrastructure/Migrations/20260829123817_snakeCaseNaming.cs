using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BudgetBoss.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class snakeCaseNaming : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Budgets_Categories_CategoryId",
                table: "Budgets");

            migrationBuilder.DropForeignKey(
                name: "FK_Budgets_Workspaces_WorkspaceId",
                table: "Budgets");

            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Workspaces_WorkspaceId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Categories_CategoryId",
                table: "Transactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Users_CreatedByUserId",
                table: "Transactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Workspaces_WorkspaceId",
                table: "Transactions");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkspaceMembers_Users_UserId",
                table: "WorkspaceMembers");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkspaceMembers_Workspaces_WorkspaceId",
                table: "WorkspaceMembers");

            migrationBuilder.DropForeignKey(
                name: "FK_Workspaces_Users_CreatedByUserId",
                table: "Workspaces");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Workspaces",
                table: "Workspaces");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Transactions",
                table: "Transactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Budgets",
                table: "Budgets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WorkspaceMembers",
                table: "WorkspaceMembers");

            migrationBuilder.RenameTable(
                name: "Workspaces",
                newName: "workspaces");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "users");

            migrationBuilder.RenameTable(
                name: "Transactions",
                newName: "transactions");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "categories");

            migrationBuilder.RenameTable(
                name: "Budgets",
                newName: "budgets");

            migrationBuilder.RenameTable(
                name: "WorkspaceMembers",
                newName: "workspace_members");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "workspaces",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "workspaces",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "workspaces",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "DeletedAt",
                table: "workspaces",
                newName: "deleted_at");

            migrationBuilder.RenameColumn(
                name: "CreatedByUserId",
                table: "workspaces",
                newName: "created_by_user_id");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "workspaces",
                newName: "created_at");

            migrationBuilder.RenameIndex(
                name: "IX_Workspaces_CreatedByUserId",
                table: "workspaces",
                newName: "ix_workspaces_created_by_user_id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "users",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "users",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "users",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "users",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "PasswordHash",
                table: "users",
                newName: "password_hash");

            migrationBuilder.RenameColumn(
                name: "DeletedAt",
                table: "users",
                newName: "deleted_at");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "users",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "transactions",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "transactions",
                newName: "date");

            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "transactions",
                newName: "amount");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "transactions",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "WorkspaceId",
                table: "transactions",
                newName: "workspace_id");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "transactions",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "DeletedAt",
                table: "transactions",
                newName: "deleted_at");

            migrationBuilder.RenameColumn(
                name: "CreatedByUserId",
                table: "transactions",
                newName: "created_by_user_id");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "transactions",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "transactions",
                newName: "category_id");

            migrationBuilder.RenameIndex(
                name: "IX_Transactions_WorkspaceId_CategoryId",
                table: "transactions",
                newName: "ix_transactions_workspace_id_category_id");

            migrationBuilder.RenameIndex(
                name: "IX_Transactions_CreatedByUserId",
                table: "transactions",
                newName: "ix_transactions_created_by_user_id");

            migrationBuilder.RenameIndex(
                name: "IX_Transactions_CategoryId",
                table: "transactions",
                newName: "ix_transactions_category_id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "categories",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Icon",
                table: "categories",
                newName: "icon");

            migrationBuilder.RenameColumn(
                name: "Color",
                table: "categories",
                newName: "color");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "categories",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "WorkspaceId",
                table: "categories",
                newName: "workspace_id");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "categories",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "DeletedAt",
                table: "categories",
                newName: "deleted_at");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "categories",
                newName: "created_at");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_WorkspaceId",
                table: "categories",
                newName: "ix_categories_workspace_id");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "budgets",
                newName: "date");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "budgets",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "WorkspaceId",
                table: "budgets",
                newName: "workspace_id");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "budgets",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "LimitAmount",
                table: "budgets",
                newName: "limit_amount");

            migrationBuilder.RenameColumn(
                name: "DeletedAt",
                table: "budgets",
                newName: "deleted_at");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "budgets",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "budgets",
                newName: "category_id");

            migrationBuilder.RenameIndex(
                name: "IX_Budgets_WorkspaceId_CategoryId_Date",
                table: "budgets",
                newName: "ix_budgets_workspace_id_category_id_date");

            migrationBuilder.RenameIndex(
                name: "IX_Budgets_CategoryId",
                table: "budgets",
                newName: "ix_budgets_category_id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "workspace_members",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "WorkspaceId",
                table: "workspace_members",
                newName: "workspace_id");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "workspace_members",
                newName: "user_id");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "workspace_members",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "workspace_members",
                newName: "created_at");

            migrationBuilder.RenameIndex(
                name: "IX_WorkspaceMembers_WorkspaceId",
                table: "workspace_members",
                newName: "ix_workspace_members_workspace_id");

            migrationBuilder.RenameIndex(
                name: "IX_WorkspaceMembers_UserId",
                table: "workspace_members",
                newName: "ix_workspace_members_user_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_workspaces",
                table: "workspaces",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_users",
                table: "users",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_transactions",
                table: "transactions",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_categories",
                table: "categories",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_budgets",
                table: "budgets",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_workspace_members",
                table: "workspace_members",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_budgets_categories_category_id",
                table: "budgets",
                column: "category_id",
                principalTable: "categories",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_budgets_workspaces_workspace_id",
                table: "budgets",
                column: "workspace_id",
                principalTable: "workspaces",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_categories_workspaces_workspace_id",
                table: "categories",
                column: "workspace_id",
                principalTable: "workspaces",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_transactions_categories_category_id",
                table: "transactions",
                column: "category_id",
                principalTable: "categories",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_transactions_users_created_by_user_id",
                table: "transactions",
                column: "created_by_user_id",
                principalTable: "users",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_transactions_workspaces_workspace_id",
                table: "transactions",
                column: "workspace_id",
                principalTable: "workspaces",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_workspace_members_users_user_id",
                table: "workspace_members",
                column: "user_id",
                principalTable: "users",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_workspace_members_workspaces_workspace_id",
                table: "workspace_members",
                column: "workspace_id",
                principalTable: "workspaces",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_workspaces_users_created_by_user_id",
                table: "workspaces",
                column: "created_by_user_id",
                principalTable: "users",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_budgets_categories_category_id",
                table: "budgets");

            migrationBuilder.DropForeignKey(
                name: "fk_budgets_workspaces_workspace_id",
                table: "budgets");

            migrationBuilder.DropForeignKey(
                name: "fk_categories_workspaces_workspace_id",
                table: "categories");

            migrationBuilder.DropForeignKey(
                name: "fk_transactions_categories_category_id",
                table: "transactions");

            migrationBuilder.DropForeignKey(
                name: "fk_transactions_users_created_by_user_id",
                table: "transactions");

            migrationBuilder.DropForeignKey(
                name: "fk_transactions_workspaces_workspace_id",
                table: "transactions");

            migrationBuilder.DropForeignKey(
                name: "fk_workspace_members_users_user_id",
                table: "workspace_members");

            migrationBuilder.DropForeignKey(
                name: "fk_workspace_members_workspaces_workspace_id",
                table: "workspace_members");

            migrationBuilder.DropForeignKey(
                name: "fk_workspaces_users_created_by_user_id",
                table: "workspaces");

            migrationBuilder.DropPrimaryKey(
                name: "pk_workspaces",
                table: "workspaces");

            migrationBuilder.DropPrimaryKey(
                name: "pk_users",
                table: "users");

            migrationBuilder.DropPrimaryKey(
                name: "pk_transactions",
                table: "transactions");

            migrationBuilder.DropPrimaryKey(
                name: "pk_categories",
                table: "categories");

            migrationBuilder.DropPrimaryKey(
                name: "pk_budgets",
                table: "budgets");

            migrationBuilder.DropPrimaryKey(
                name: "pk_workspace_members",
                table: "workspace_members");

            migrationBuilder.RenameTable(
                name: "workspaces",
                newName: "Workspaces");

            migrationBuilder.RenameTable(
                name: "users",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "transactions",
                newName: "Transactions");

            migrationBuilder.RenameTable(
                name: "categories",
                newName: "Categories");

            migrationBuilder.RenameTable(
                name: "budgets",
                newName: "Budgets");

            migrationBuilder.RenameTable(
                name: "workspace_members",
                newName: "WorkspaceMembers");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Workspaces",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Workspaces",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "Workspaces",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "deleted_at",
                table: "Workspaces",
                newName: "DeletedAt");

            migrationBuilder.RenameColumn(
                name: "created_by_user_id",
                table: "Workspaces",
                newName: "CreatedByUserId");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "Workspaces",
                newName: "CreatedAt");

            migrationBuilder.RenameIndex(
                name: "ix_workspaces_created_by_user_id",
                table: "Workspaces",
                newName: "IX_Workspaces_CreatedByUserId");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Users",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Users",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Users",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "Users",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "password_hash",
                table: "Users",
                newName: "PasswordHash");

            migrationBuilder.RenameColumn(
                name: "deleted_at",
                table: "Users",
                newName: "DeletedAt");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "Users",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Transactions",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "date",
                table: "Transactions",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "amount",
                table: "Transactions",
                newName: "Amount");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Transactions",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "workspace_id",
                table: "Transactions",
                newName: "WorkspaceId");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "Transactions",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "deleted_at",
                table: "Transactions",
                newName: "DeletedAt");

            migrationBuilder.RenameColumn(
                name: "created_by_user_id",
                table: "Transactions",
                newName: "CreatedByUserId");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "Transactions",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "category_id",
                table: "Transactions",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "ix_transactions_workspace_id_category_id",
                table: "Transactions",
                newName: "IX_Transactions_WorkspaceId_CategoryId");

            migrationBuilder.RenameIndex(
                name: "ix_transactions_created_by_user_id",
                table: "Transactions",
                newName: "IX_Transactions_CreatedByUserId");

            migrationBuilder.RenameIndex(
                name: "ix_transactions_category_id",
                table: "Transactions",
                newName: "IX_Transactions_CategoryId");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Categories",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "icon",
                table: "Categories",
                newName: "Icon");

            migrationBuilder.RenameColumn(
                name: "color",
                table: "Categories",
                newName: "Color");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Categories",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "workspace_id",
                table: "Categories",
                newName: "WorkspaceId");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "Categories",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "deleted_at",
                table: "Categories",
                newName: "DeletedAt");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "Categories",
                newName: "CreatedAt");

            migrationBuilder.RenameIndex(
                name: "ix_categories_workspace_id",
                table: "Categories",
                newName: "IX_Categories_WorkspaceId");

            migrationBuilder.RenameColumn(
                name: "date",
                table: "Budgets",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Budgets",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "workspace_id",
                table: "Budgets",
                newName: "WorkspaceId");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "Budgets",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "limit_amount",
                table: "Budgets",
                newName: "LimitAmount");

            migrationBuilder.RenameColumn(
                name: "deleted_at",
                table: "Budgets",
                newName: "DeletedAt");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "Budgets",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "category_id",
                table: "Budgets",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "ix_budgets_workspace_id_category_id_date",
                table: "Budgets",
                newName: "IX_Budgets_WorkspaceId_CategoryId_Date");

            migrationBuilder.RenameIndex(
                name: "ix_budgets_category_id",
                table: "Budgets",
                newName: "IX_Budgets_CategoryId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "WorkspaceMembers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "workspace_id",
                table: "WorkspaceMembers",
                newName: "WorkspaceId");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "WorkspaceMembers",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "WorkspaceMembers",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "WorkspaceMembers",
                newName: "CreatedAt");

            migrationBuilder.RenameIndex(
                name: "ix_workspace_members_workspace_id",
                table: "WorkspaceMembers",
                newName: "IX_WorkspaceMembers_WorkspaceId");

            migrationBuilder.RenameIndex(
                name: "ix_workspace_members_user_id",
                table: "WorkspaceMembers",
                newName: "IX_WorkspaceMembers_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Workspaces",
                table: "Workspaces",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transactions",
                table: "Transactions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Budgets",
                table: "Budgets",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WorkspaceMembers",
                table: "WorkspaceMembers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Budgets_Categories_CategoryId",
                table: "Budgets",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Budgets_Workspaces_WorkspaceId",
                table: "Budgets",
                column: "WorkspaceId",
                principalTable: "Workspaces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Workspaces_WorkspaceId",
                table: "Categories",
                column: "WorkspaceId",
                principalTable: "Workspaces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Categories_CategoryId",
                table: "Transactions",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Users_CreatedByUserId",
                table: "Transactions",
                column: "CreatedByUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Workspaces_WorkspaceId",
                table: "Transactions",
                column: "WorkspaceId",
                principalTable: "Workspaces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkspaceMembers_Users_UserId",
                table: "WorkspaceMembers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkspaceMembers_Workspaces_WorkspaceId",
                table: "WorkspaceMembers",
                column: "WorkspaceId",
                principalTable: "Workspaces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Workspaces_Users_CreatedByUserId",
                table: "Workspaces",
                column: "CreatedByUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
