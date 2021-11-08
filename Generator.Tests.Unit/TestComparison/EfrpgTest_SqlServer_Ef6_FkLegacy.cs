// <auto-generated>

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.Infrastructure.Interception;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.Spatial;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace Efrpg.V3TestB
{
    #region Database context interface

    public interface IEfrpgTestDbContext : IDisposable
    {
        DbSet<ColumnName> ColumnNames { get; set; } // ColumnNames
        DbSet<EnumsWithStringAsValue> EnumsWithStringAsValues { get; set; } // EnumsWithStringAsValue
        DbSet<EnumTest_DaysOfWeek> EnumTest_DaysOfWeeks { get; set; } // DaysOfWeek
        DbSet<Stafford_Boo> Stafford_Boos { get; set; } // Boo
        DbSet<Stafford_ComputedColumn> Stafford_ComputedColumns { get; set; } // ComputedColumns
        DbSet<Stafford_Foo> Stafford_Foos { get; set; } // Foo
        DbSet<Synonyms_Child> Synonyms_Children { get; set; } // Child
        DbSet<Synonyms_Parent> Synonyms_Parents { get; set; } // Parent

        int SaveChanges();
        Task<int> SaveChangesAsync();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        DbChangeTracker ChangeTracker { get; }
        DbContextConfiguration Configuration { get; }
        Database Database { get; }
        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
        DbEntityEntry Entry(object entity);
        IEnumerable<DbEntityValidationResult> GetValidationErrors();
        DbSet Set(Type entityType);
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        string ToString();

        // Stored Procedures
        List<Synonyms_SimpleStoredProcReturnModel> Synonyms_SimpleStoredProc(int? inputInt);
        List<Synonyms_SimpleStoredProcReturnModel> Synonyms_SimpleStoredProc(int? inputInt, out int procResult);
        Task<List<Synonyms_SimpleStoredProcReturnModel>> Synonyms_SimpleStoredProcAsync(int? inputInt);


        // Table Valued Functions

        [DbFunction("EfrpgTestDbContext", "CsvToInt")]
        [CodeFirstStoreFunctions.DbFunctionDetails(DatabaseSchema = "dbo")]
        IQueryable<CsvToIntReturnModel> CsvToInt(string array, string array2);

        [DbFunction("EfrpgTestDbContext", "CsvToIntWithSchema")]
        [CodeFirstStoreFunctions.DbFunctionDetails(DatabaseSchema = "CustomSchema")]
        IQueryable<CustomSchema_CsvToIntWithSchemaReturnModel> CustomSchema_CsvToIntWithSchema(string array, string array2);

        // Scalar Valued Functions
        decimal UdfNetSale(int? quantity, decimal? listPrice, decimal? discount); // dbo.udfNetSale
    }

    #endregion

    #region Database context

    public class EfrpgTestDbContext : DbContext, IEfrpgTestDbContext
    {
        public DbSet<ColumnName> ColumnNames { get; set; } // ColumnNames
        public DbSet<EnumsWithStringAsValue> EnumsWithStringAsValues { get; set; } // EnumsWithStringAsValue
        public DbSet<EnumTest_DaysOfWeek> EnumTest_DaysOfWeeks { get; set; } // DaysOfWeek
        public DbSet<Stafford_Boo> Stafford_Boos { get; set; } // Boo
        public DbSet<Stafford_ComputedColumn> Stafford_ComputedColumns { get; set; } // ComputedColumns
        public DbSet<Stafford_Foo> Stafford_Foos { get; set; } // Foo
        public DbSet<Synonyms_Child> Synonyms_Children { get; set; } // Child
        public DbSet<Synonyms_Parent> Synonyms_Parents { get; set; } // Parent

        static EfrpgTestDbContext()
        {
            System.Data.Entity.Database.SetInitializer<EfrpgTestDbContext>(null);
        }

        /// <inheritdoc />
        public EfrpgTestDbContext()
            : base("Name=MyDbContext")
        {
        }

        /// <inheritdoc />
        public EfrpgTestDbContext(string connectionString)
            : base(connectionString)
        {
        }

        /// <inheritdoc />
        public EfrpgTestDbContext(string connectionString, DbCompiledModel model)
            : base(connectionString, model)
        {
        }

        /// <inheritdoc />
        public EfrpgTestDbContext(DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {
        }

        /// <inheritdoc />
        public EfrpgTestDbContext(DbConnection existingConnection, DbCompiledModel model, bool contextOwnsConnection)
            : base(existingConnection, model, contextOwnsConnection)
        {
        }

        /// <inheritdoc />
        public EfrpgTestDbContext(ObjectContext objectContext, bool dbContextOwnsObjectContext)
            : base(objectContext, dbContextOwnsObjectContext)
        {
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public bool IsSqlParameterNull(SqlParameter param)
        {
            var sqlValue = param.SqlValue;
            var nullableValue = sqlValue as INullable;
            if (nullableValue != null)
                return nullableValue.IsNull;
            return (sqlValue == null || sqlValue == DBNull.Value);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Add(new CodeFirstStoreFunctions.FunctionsConvention<EfrpgTestDbContext>("dbo"));

            modelBuilder.ComplexType<CsvToIntReturnModel>();
            modelBuilder.ComplexType<CustomSchema_CsvToIntWithSchemaReturnModel>();

            modelBuilder.Configurations.Add(new ColumnNameConfiguration());
            modelBuilder.Configurations.Add(new EnumsWithStringAsValueConfiguration());
            modelBuilder.Configurations.Add(new EnumTest_DaysOfWeekConfiguration());
            modelBuilder.Configurations.Add(new Stafford_BooConfiguration());
            modelBuilder.Configurations.Add(new Stafford_ComputedColumnConfiguration());
            modelBuilder.Configurations.Add(new Stafford_FooConfiguration());
            modelBuilder.Configurations.Add(new Synonyms_ChildConfiguration());
            modelBuilder.Configurations.Add(new Synonyms_ParentConfiguration());
        }

        public static DbModelBuilder CreateModel(DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new ColumnNameConfiguration(schema));
            modelBuilder.Configurations.Add(new EnumsWithStringAsValueConfiguration(schema));
            modelBuilder.Configurations.Add(new EnumTest_DaysOfWeekConfiguration(schema));
            modelBuilder.Configurations.Add(new Stafford_BooConfiguration(schema));
            modelBuilder.Configurations.Add(new Stafford_ComputedColumnConfiguration(schema));
            modelBuilder.Configurations.Add(new Stafford_FooConfiguration(schema));
            modelBuilder.Configurations.Add(new Synonyms_ChildConfiguration(schema));
            modelBuilder.Configurations.Add(new Synonyms_ParentConfiguration(schema));

            return modelBuilder;
        }

        // Stored Procedures
        public List<Synonyms_SimpleStoredProcReturnModel> Synonyms_SimpleStoredProc(int? inputInt)
        {
            int procResult;
            return Synonyms_SimpleStoredProc(inputInt, out procResult);
        }

        public List<Synonyms_SimpleStoredProcReturnModel> Synonyms_SimpleStoredProc(int? inputInt, out int procResult)
        {
            var inputIntParam = new SqlParameter { ParameterName = "@InputInt", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = inputInt.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!inputInt.HasValue)
                inputIntParam.Value = DBNull.Value;

            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
            var procResultData = Database.SqlQuery<Synonyms_SimpleStoredProcReturnModel>("EXEC @procResult = [Synonyms].[SimpleStoredProc] @InputInt", inputIntParam, procResultParam).ToList();
            procResult = (int) procResultParam.Value;
            return procResultData;
        }

        public async Task<List<Synonyms_SimpleStoredProcReturnModel>> Synonyms_SimpleStoredProcAsync(int? inputInt)
        {
            var inputIntParam = new SqlParameter { ParameterName = "@InputInt", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = inputInt.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!inputInt.HasValue)
                inputIntParam.Value = DBNull.Value;

            var procResultData = await Database.SqlQuery<Synonyms_SimpleStoredProcReturnModel>("EXEC [Synonyms].[SimpleStoredProc] @InputInt", inputIntParam).ToListAsync();
            return procResultData;
        }


        // Table Valued Functions

        [DbFunction("EfrpgTestDbContext", "CsvToInt")]
        [CodeFirstStoreFunctions.DbFunctionDetails(DatabaseSchema = "dbo")]
        public IQueryable<CsvToIntReturnModel> CsvToInt(string array, string array2)
        {
            var arrayParam = new ObjectParameter("array", typeof(string)) { Value = (object)array };
            var array2Param = new ObjectParameter("array2", typeof(string)) { Value = (object)array2 };

            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<CsvToIntReturnModel>("[EfrpgTestDbContext].[CsvToInt](@array, @array2)", arrayParam, array2Param);
        }

        [DbFunction("EfrpgTestDbContext", "CsvToIntWithSchema")]
        [CodeFirstStoreFunctions.DbFunctionDetails(DatabaseSchema = "CustomSchema")]
        public IQueryable<CustomSchema_CsvToIntWithSchemaReturnModel> CustomSchema_CsvToIntWithSchema(string array, string array2)
        {
            var arrayParam = new ObjectParameter("array", typeof(string)) { Value = (object)array };
            var array2Param = new ObjectParameter("array2", typeof(string)) { Value = (object)array2 };

            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<CustomSchema_CsvToIntWithSchemaReturnModel>("[EfrpgTestDbContext].[CsvToIntWithSchema](@array, @array2)", arrayParam, array2Param);
        }

        // Scalar Valued Functions

        [DbFunction("CodeFirstDatabaseSchema", "udfNetSale")]
        public decimal UdfNetSale(int? quantity, decimal? listPrice, decimal? discount)
        {
            throw new Exception("Don't call this directly. Use LINQ to call the scalar valued function as part of your query");
        }
    }

    #endregion

    #region Database context factory

    public class EfrpgTestDbContextFactory : IDbContextFactory<EfrpgTestDbContext>
    {
        public EfrpgTestDbContext Create()
        {
            return new EfrpgTestDbContext();
        }
    }

    #endregion

    #region Fake Database context

    public class FakeEfrpgTestDbContext : IEfrpgTestDbContext
    {
        public DbSet<ColumnName> ColumnNames { get; set; } // ColumnNames
        public DbSet<EnumsWithStringAsValue> EnumsWithStringAsValues { get; set; } // EnumsWithStringAsValue
        public DbSet<EnumTest_DaysOfWeek> EnumTest_DaysOfWeeks { get; set; } // DaysOfWeek
        public DbSet<Stafford_Boo> Stafford_Boos { get; set; } // Boo
        public DbSet<Stafford_ComputedColumn> Stafford_ComputedColumns { get; set; } // ComputedColumns
        public DbSet<Stafford_Foo> Stafford_Foos { get; set; } // Foo
        public DbSet<Synonyms_Child> Synonyms_Children { get; set; } // Child
        public DbSet<Synonyms_Parent> Synonyms_Parents { get; set; } // Parent

        public FakeEfrpgTestDbContext()
        {
            _changeTracker = null;
            _configuration = null;
            _database = null;

            ColumnNames = new FakeDbSet<ColumnName>("C36");
            EnumsWithStringAsValues = new FakeDbSet<EnumsWithStringAsValue>("EnumName", "Value");
            EnumTest_DaysOfWeeks = new FakeDbSet<EnumTest_DaysOfWeek>("TypeName", "TypeId");
            Stafford_Boos = new FakeDbSet<Stafford_Boo>("Id");
            Stafford_ComputedColumns = new FakeDbSet<Stafford_ComputedColumn>("Id");
            Stafford_Foos = new FakeDbSet<Stafford_Foo>("Id");
            Synonyms_Children = new FakeDbSet<Synonyms_Child>("ChildId");
            Synonyms_Parents = new FakeDbSet<Synonyms_Parent>("ParentId");

        }

        public int SaveChangesCount { get; private set; }
        public int SaveChanges()
        {
            ++SaveChangesCount;
            return 1;
        }

        public Task<int> SaveChangesAsync()
        {
            ++SaveChangesCount;
            return Task<int>.Factory.StartNew(() => 1);
        }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            ++SaveChangesCount;
            return Task<int>.Factory.StartNew(() => 1, cancellationToken);
        }

        protected virtual void Dispose(bool disposing)
        {
        }

        public void Dispose()
        {
            Dispose(true);
        }

        private DbChangeTracker _changeTracker;

        public DbChangeTracker ChangeTracker { get { return _changeTracker; } }

        private DbContextConfiguration _configuration;

        public DbContextConfiguration Configuration { get { return _configuration; } }

        private Database _database;

        public Database Database { get { return _database; } }

        public DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public DbEntityEntry Entry(object entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DbEntityValidationResult> GetValidationErrors()
        {
            throw new NotImplementedException();
        }

        public DbSet Set(Type entityType)
        {
            throw new NotImplementedException();
        }

        public DbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }

        // Stored Procedures

        public List<Synonyms_SimpleStoredProcReturnModel> Synonyms_SimpleStoredProc(int? inputInt)
        {
            int procResult;
            return Synonyms_SimpleStoredProc(inputInt, out procResult);
        }

        public List<Synonyms_SimpleStoredProcReturnModel> Synonyms_SimpleStoredProc(int? inputInt, out int procResult)
        {
            procResult = 0;
            return new List<Synonyms_SimpleStoredProcReturnModel>();
        }

        public Task<List<Synonyms_SimpleStoredProcReturnModel>> Synonyms_SimpleStoredProcAsync(int? inputInt)
        {
            int procResult;
            return Task.FromResult(Synonyms_SimpleStoredProc(inputInt, out procResult));
        }

        // Table Valued Functions

        [DbFunction("EfrpgTestDbContext", "CsvToInt")]
        public IQueryable<CsvToIntReturnModel> CsvToInt(string array, string array2)
        {
            return new List<CsvToIntReturnModel>().AsQueryable();
        }

        [DbFunction("EfrpgTestDbContext", "CsvToIntWithSchema")]
        public IQueryable<CustomSchema_CsvToIntWithSchemaReturnModel> CustomSchema_CsvToIntWithSchema(string array, string array2)
        {
            return new List<CustomSchema_CsvToIntWithSchemaReturnModel>().AsQueryable();
        }

        // Scalar Valued Functions

        // dbo.udfNetSale
        public decimal UdfNetSale(int? quantity, decimal? listPrice, decimal? discount)
        {
            return default(decimal);
        }
    }

    #endregion

    #region Fake DbSet

    // ************************************************************************
    // Fake DbSet
    // Implementing Find:
    //      The Find method is difficult to implement in a generic fashion. If
    //      you need to test code that makes use of the Find method it is
    //      easiest to create a test DbSet for each of the entity types that
    //      need to support find. You can then write logic to find that
    //      particular type of entity, as shown below:
    //      public class FakeBlogDbSet : FakeDbSet<Blog>
    //      {
    //          public override Blog Find(params object[] keyValues)
    //          {
    //              var id = (int) keyValues.Single();
    //              return this.SingleOrDefault(b => b.BlogId == id);
    //          }
    //      }
    //      Read more about it here: https://msdn.microsoft.com/en-us/data/dn314431.aspx
    public class FakeDbSet<TEntity> : DbSet<TEntity>, IQueryable, IEnumerable<TEntity>, IDbAsyncEnumerable<TEntity> where TEntity : class
    {
        private readonly PropertyInfo[] _primaryKeys;
        private readonly ObservableCollection<TEntity> _data;
        private readonly IQueryable _query;

        public FakeDbSet()
        {
            _data = new ObservableCollection<TEntity>();
            _query = _data.AsQueryable();
        }

        public FakeDbSet(params string[] primaryKeys)
        {
            _primaryKeys = typeof(TEntity).GetProperties().Where(x => primaryKeys.Contains(x.Name)).ToArray();
            _data = new ObservableCollection<TEntity>();
            _query = _data.AsQueryable();
        }

        public override TEntity Find(params object[] keyValues)
        {
            if (_primaryKeys == null)
                throw new ArgumentException("No primary keys defined");
            if (keyValues.Length != _primaryKeys.Length)
                throw new ArgumentException("Incorrect number of keys passed to Find method");

            var keyQuery = this.AsQueryable();
            keyQuery = keyValues
                .Select((t, i) => i)
                .Aggregate(keyQuery,
                    (current, x) =>
                        current.Where(entity => _primaryKeys[x].GetValue(entity, null).Equals(keyValues[x])));

            return keyQuery.SingleOrDefault();
        }

        public override Task<TEntity> FindAsync(CancellationToken cancellationToken, params object[] keyValues)
        {
            return Task<TEntity>.Factory.StartNew(() => Find(keyValues), cancellationToken);
        }

        public override Task<TEntity> FindAsync(params object[] keyValues)
        {
            return Task<TEntity>.Factory.StartNew(() => Find(keyValues));
        }

        public override IEnumerable<TEntity> AddRange(IEnumerable<TEntity> entities)
        {
            if (entities == null) throw new ArgumentNullException("entities");
            var items = entities.ToList();
            foreach (var entity in items)
            {
                _data.Add(entity);
            }
            return items;
        }

        public override TEntity Add(TEntity item)
        {
            if (item == null) throw new ArgumentNullException("item");
            _data.Add(item);
            return item;
        }

        public override IEnumerable<TEntity> RemoveRange(IEnumerable<TEntity> entities)
        {
            if (entities == null) throw new ArgumentNullException("entities");
            var items = entities.ToList();
            foreach (var entity in items)
            {
                _data.Remove(entity);
            }
            return items;
        }

        public override TEntity Remove(TEntity item)
        {
            if (item == null) throw new ArgumentNullException("item");
            _data.Remove(item);
            return item;
        }

        public override TEntity Attach(TEntity item)
        {
            if (item == null) throw new ArgumentNullException("item");
            _data.Add(item);
            return item;
        }

        public override TEntity Create()
        {
            return Activator.CreateInstance<TEntity>();
        }

        public override TDerivedEntity Create<TDerivedEntity>()
        {
            return Activator.CreateInstance<TDerivedEntity>();
        }

        public override ObservableCollection<TEntity> Local
        {
            get { return _data; }
        }

        Type IQueryable.ElementType
        {
            get { return _query.ElementType; }
        }

        Expression IQueryable.Expression
        {
            get { return _query.Expression; }
        }

        IQueryProvider IQueryable.Provider
        {
            get { return new FakeDbAsyncQueryProvider<TEntity>(_query.Provider); }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _data.GetEnumerator();
        }

        IEnumerator<TEntity> IEnumerable<TEntity>.GetEnumerator()
        {
            return _data.GetEnumerator();
        }

        IDbAsyncEnumerator<TEntity> IDbAsyncEnumerable<TEntity>.GetAsyncEnumerator()
        {
            return new FakeDbAsyncEnumerator<TEntity>(_data.GetEnumerator());
        }
    }

    public class FakeDbAsyncQueryProvider<TEntity> : IDbAsyncQueryProvider
    {
        private readonly IQueryProvider _inner;

        public FakeDbAsyncQueryProvider(IQueryProvider inner)
        {
            _inner = inner;
        }

        public IQueryable CreateQuery(Expression expression)
        {
            var m = expression as MethodCallExpression;
            if (m != null)
            {
                var resultType = m.Method.ReturnType; // it should be IQueryable<T>
                var tElement = resultType.GetGenericArguments()[0];
                var queryType = typeof(FakeDbAsyncEnumerable<>).MakeGenericType(tElement);
                return (IQueryable) Activator.CreateInstance(queryType, expression);
            }
            return new FakeDbAsyncEnumerable<TEntity>(expression);
        }

        public IQueryable<TElement> CreateQuery<TElement>(Expression expression)
        {
            var queryType = typeof(FakeDbAsyncEnumerable<>).MakeGenericType(typeof(TElement));
            return (IQueryable<TElement>) Activator.CreateInstance(queryType, expression);
        }

        public object Execute(Expression expression)
        {
            return _inner.Execute(expression);
        }

        public TResult Execute<TResult>(Expression expression)
        {
            return _inner.Execute<TResult>(expression);
        }

        public Task<object> ExecuteAsync(Expression expression, CancellationToken cancellationToken)
        {
            return Task.FromResult(Execute(expression));
        }

        public Task<TResult> ExecuteAsync<TResult>(Expression expression, CancellationToken cancellationToken)
        {
            return Task.FromResult(Execute<TResult>(expression));
        }
    }

    public class FakeDbAsyncEnumerable<T> : EnumerableQuery<T>, IDbAsyncEnumerable<T>, IQueryable<T>
    {
        public FakeDbAsyncEnumerable(IEnumerable<T> enumerable)
            : base(enumerable)
        { }

        public FakeDbAsyncEnumerable(Expression expression)
            : base(expression)
        { }

        public IDbAsyncEnumerator<T> GetAsyncEnumerator()
        {
            return new FakeDbAsyncEnumerator<T>(this.AsEnumerable().GetEnumerator());
        }

        IDbAsyncEnumerator IDbAsyncEnumerable.GetAsyncEnumerator()
        {
            return GetAsyncEnumerator();
        }

        IQueryProvider IQueryable.Provider
        {
            get { return new FakeDbAsyncQueryProvider<T>(this); }
        }

    }

    public class FakeDbAsyncEnumerator<T> : IDbAsyncEnumerator<T>
    {
        private readonly IEnumerator<T> _inner;

        public FakeDbAsyncEnumerator(IEnumerator<T> inner)
        {
            _inner = inner;
        }

        public void Dispose()
        {
            _inner.Dispose();
        }

        public Task<bool> MoveNextAsync(CancellationToken cancellationToken)
        {
            return Task.FromResult(_inner.MoveNext());
        }

        public T Current
        {
            get { return _inner.Current; }
        }

        object IDbAsyncEnumerator.Current
        {
            get { return Current; }
        }
    }

    #endregion

    #region POCO classes

    // ColumnNames
    /// <summary>
    /// This is to document the
    /// table with poor column name choices
    /// </summary>
    public class ColumnName
    {
        public int C36 { get; set; } // $ (Primary key)
        public int? C37 { get; set; } // %
        public int? C163 { get; set; } // £

        /// <summary>
        /// Multi
            ///        Line
            ///    Comment
        /// </summary>
        public int? C38Test36 { get; set; } // &test$
        public int? Abc4792 { get; set; } // abc/\
        public int? Joe46Bloggs { get; set; } // joe.bloggs
        public int? SnakeCase { get; set; } // snake-case
        public string DefaultTest { get; set; } // default_test (length: 20)
        public DateTime SomeDate { get; set; } // someDate
        public string Obs { get; set; } // Obs (length: 20)
        public string Slash1 { get; set; } // Slash1 (length: 20)
        public string Slash2 { get; set; } // Slash2 (length: 20)
        public string Slash3 { get; set; } // Slash3 (length: 20)
        public int? @Static { get; set; } // static
        public int? @Readonly { get; set; } // readonly
        public int? C123Hi { get; set; } // 123Hi
        public float? Afloat { get; set; } // afloat
        public double? Adouble { get; set; } // adouble
        public decimal? Adecimal { get; set; } // adecimal

        public ColumnName()
        {
            DefaultTest = "";
            SomeDate = DateTime.Now;
            Obs = "[{\"k\":\"en\",\"v\":\"\"},{\"k\":\"pt\",\"v\":\"\"}]";
            Slash1 = @"\";
            Slash2 = @"\\";
            Slash3 = @"\\\";
            Afloat = 1.23f;
            Adouble = 999.0;
        }
    }

    // EnumsWithStringAsValue
    public class EnumsWithStringAsValue
    {
        public string EnumName { get; set; } // enum_name (Primary key) (length: 50)
        public string Value { get; set; } // value (Primary key) (length: 10)
    }

    // DaysOfWeek
    public class EnumTest_DaysOfWeek
    {
        public string TypeName { get; set; } // TypeName (Primary key) (length: 50)
        public int TypeId { get; set; } // TypeId (Primary key)
    }

    // The table 'NoPrimaryKeys' is not usable by entity framework because it
    // does not have a primary key. It is listed here for completeness.
    // NoPrimaryKeys
    public class NoPrimaryKey
    {
        public int? Id { get; set; } // Id
        public string Description { get; set; } // Description (length: 10)
    }

    // Boo
    public class Stafford_Boo
    {
        public int Id { get; set; } // id (Primary key)
        public string Name { get; set; } // name (length: 10)

        // Reverse navigation

        /// <summary>
        /// Parent (One-to-One) Stafford_Boo pointed by [Foo].[id] (FK_Foo_Boo)
        /// </summary>
        public virtual Stafford_Foo Stafford_Foo { get; set; } // Foo.FK_Foo_Boo
    }

    // ComputedColumns
    public class Stafford_ComputedColumn
    {
        public int Id { get; set; } // Id (Primary key)
        public string MyColumn { get; set; } // MyColumn (length: 10)
        public string MyComputedColumn { get; private set; } // MyComputedColumn (length: 10)
    }

    // Foo
    public class Stafford_Foo
    {
        public int Id { get; set; } // id (Primary key)
        public string Name { get; set; } // name (length: 10)

        // Foreign keys

        /// <summary>
        /// Parent Stafford_Boo pointed by [Foo].([Id]) (FK_Foo_Boo)
        /// </summary>
        public virtual Stafford_Boo Stafford_Boo { get; set; } // FK_Foo_Boo
    }

    // Child
    public class Synonyms_Child
    {
        public int ChildId { get; set; } // ChildId (Primary key)
        public int ParentId { get; set; } // ParentId
        public string ChildName { get; set; } // ChildName (length: 100)

        // Foreign keys

        /// <summary>
        /// Parent Synonyms_Parent pointed by [Child].([ParentId]) (FK_Child_Parent)
        /// </summary>
        public virtual Synonyms_Parent Synonyms_Parent { get; set; } // FK_Child_Parent
    }

    // Parent
    public class Synonyms_Parent
    {
        public int ParentId { get; set; } // ParentId (Primary key)
        public string ParentName { get; set; } // ParentName (length: 100)

        // Reverse navigation

        /// <summary>
        /// Child Synonyms_Children where [Child].[ParentId] point to this entity (FK_Child_Parent)
        /// </summary>
        public virtual ICollection<Synonyms_Child> Synonyms_Children { get; set; } // Child.FK_Child_Parent

        public Synonyms_Parent()
        {
            Synonyms_Children = new List<Synonyms_Child>();
        }
    }


    #endregion

    #region POCO Configuration

    // ColumnNames
    public class ColumnNameConfiguration : EntityTypeConfiguration<ColumnName>
    {
        public ColumnNameConfiguration()
            : this("dbo")
        {
        }

        public ColumnNameConfiguration(string schema)
        {
            ToTable("ColumnNames", schema);
            HasKey(x => x.C36);

            Property(x => x.C36).HasColumnName(@"$").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.C37).HasColumnName(@"%").HasColumnType("int").IsOptional();
            Property(x => x.C163).HasColumnName(@"£").HasColumnType("int").IsOptional();
            Property(x => x.C38Test36).HasColumnName(@"&test$").HasColumnType("int").IsOptional();
            Property(x => x.Abc4792).HasColumnName(@"abc/\").HasColumnType("int").IsOptional();
            Property(x => x.Joe46Bloggs).HasColumnName(@"joe.bloggs").HasColumnType("int").IsOptional();
            Property(x => x.SnakeCase).HasColumnName(@"snake-case").HasColumnType("int").IsOptional();
            Property(x => x.DefaultTest).HasColumnName(@"default_test").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.SomeDate).HasColumnName(@"someDate").HasColumnType("datetime2").IsRequired();
            Property(x => x.Obs).HasColumnName(@"Obs").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Slash1).HasColumnName(@"Slash1").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Slash2).HasColumnName(@"Slash2").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Slash3).HasColumnName(@"Slash3").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(20);
            Property(x => x.@Static).HasColumnName(@"static").HasColumnType("int").IsOptional();
            Property(x => x.@Readonly).HasColumnName(@"readonly").HasColumnType("int").IsOptional();
            Property(x => x.C123Hi).HasColumnName(@"123Hi").HasColumnType("int").IsOptional();
            Property(x => x.Afloat).HasColumnName(@"afloat").HasColumnType("real").IsOptional();
            Property(x => x.Adouble).HasColumnName(@"adouble").HasColumnType("float").IsOptional();
            Property(x => x.Adecimal).HasColumnName(@"adecimal").HasColumnType("decimal").IsOptional().HasPrecision(19,4);
        }
    }

    // EnumsWithStringAsValue
    public class EnumsWithStringAsValueConfiguration : EntityTypeConfiguration<EnumsWithStringAsValue>
    {
        public EnumsWithStringAsValueConfiguration()
            : this("dbo")
        {
        }

        public EnumsWithStringAsValueConfiguration(string schema)
        {
            ToTable("EnumsWithStringAsValue", schema);
            HasKey(x => new { x.EnumName, x.Value });

            Property(x => x.EnumName).HasColumnName(@"enum_name").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Value).HasColumnName(@"value").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
        }
    }

    // DaysOfWeek
    public class EnumTest_DaysOfWeekConfiguration : EntityTypeConfiguration<EnumTest_DaysOfWeek>
    {
        public EnumTest_DaysOfWeekConfiguration()
            : this("EnumTest")
        {
        }

        public EnumTest_DaysOfWeekConfiguration(string schema)
        {
            ToTable("DaysOfWeek", schema);
            HasKey(x => new { x.TypeName, x.TypeId });

            Property(x => x.TypeName).HasColumnName(@"TypeName").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.TypeId).HasColumnName(@"TypeId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
        }
    }

    // Boo
    public class Stafford_BooConfiguration : EntityTypeConfiguration<Stafford_Boo>
    {
        public Stafford_BooConfiguration()
            : this("Stafford")
        {
        }

        public Stafford_BooConfiguration(string schema)
        {
            ToTable("Boo", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName(@"name").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(10);
        }
    }

    // ComputedColumns
    public class Stafford_ComputedColumnConfiguration : EntityTypeConfiguration<Stafford_ComputedColumn>
    {
        public Stafford_ComputedColumnConfiguration()
            : this("Stafford")
        {
        }

        public Stafford_ComputedColumnConfiguration(string schema)
        {
            ToTable("ComputedColumns", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.MyColumn).HasColumnName(@"MyColumn").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.MyComputedColumn).HasColumnName(@"MyComputedColumn").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
        }
    }

    // Foo
    public class Stafford_FooConfiguration : EntityTypeConfiguration<Stafford_Foo>
    {
        public Stafford_FooConfiguration()
            : this("Stafford")
        {
        }

        public Stafford_FooConfiguration(string schema)
        {
            ToTable("Foo", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Name).HasColumnName(@"name").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(10);

            // Foreign keys
            HasRequired(a => a.Stafford_Boo).WithOptional(b => b.Stafford_Foo).WillCascadeOnDelete(false); // FK_Foo_Boo
        }
    }

    // Child
    public class Synonyms_ChildConfiguration : EntityTypeConfiguration<Synonyms_Child>
    {
        public Synonyms_ChildConfiguration()
            : this("Synonyms")
        {
        }

        public Synonyms_ChildConfiguration(string schema)
        {
            ToTable("Child", schema);
            HasKey(x => x.ChildId);

            Property(x => x.ChildId).HasColumnName(@"ChildId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ParentId).HasColumnName(@"ParentId").HasColumnType("int").IsRequired();
            Property(x => x.ChildName).HasColumnName(@"ChildName").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);

            // Foreign keys
            HasRequired(a => a.Synonyms_Parent).WithMany(b => b.Synonyms_Children).HasForeignKey(c => c.ParentId).WillCascadeOnDelete(false); // FK_Child_Parent
        }
    }

    // Parent
    public class Synonyms_ParentConfiguration : EntityTypeConfiguration<Synonyms_Parent>
    {
        public Synonyms_ParentConfiguration()
            : this("Synonyms")
        {
        }

        public Synonyms_ParentConfiguration(string schema)
        {
            ToTable("Parent", schema);
            HasKey(x => x.ParentId);

            Property(x => x.ParentId).HasColumnName(@"ParentId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ParentName).HasColumnName(@"ParentName").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
        }
    }


    #endregion

    #region Enumerations

    public enum CarOptions
    {
        SunRoof = 0x01,
        Spoiler = 0x02,
        FogLights = 0x04,
        TintedWindows = 0x08,
    }

    public enum DaysOfWeek
    {
        Sun = 0,
        Mon = 1,
        Tue = 2,
        Wed = 3,
        Thu = 4,
        Fri = 6,
        Sat = 7,
    }


    #endregion

    #region Stored procedure return models

    public class Synonyms_SimpleStoredProcReturnModel
    {
        public string ReturnValue { get; set; }
    }


    #endregion

}
// </auto-generated>
