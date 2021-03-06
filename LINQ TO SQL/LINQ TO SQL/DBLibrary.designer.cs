#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LINQ_TO_SQL
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="LTSLibrary")]
	public partial class DBLibraryDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Определения метода расширяемости
    partial void OnCreated();
    partial void InsertAuthors(Authors instance);
    partial void UpdateAuthors(Authors instance);
    partial void DeleteAuthors(Authors instance);
    partial void InsertBooks(Books instance);
    partial void UpdateBooks(Books instance);
    partial void DeleteBooks(Books instance);
    partial void InsertCountries(Countries instance);
    partial void UpdateCountries(Countries instance);
    partial void DeleteCountries(Countries instance);
    #endregion
		
		public DBLibraryDataContext() : 
				base(global::LINQ_TO_SQL.Properties.Settings.Default.LTSLibraryConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DBLibraryDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBLibraryDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBLibraryDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBLibraryDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Authors> Authors
		{
			get
			{
				return this.GetTable<Authors>();
			}
		}
		
		public System.Data.Linq.Table<Books> Books
		{
			get
			{
				return this.GetTable<Books>();
			}
		}
		
		public System.Data.Linq.Table<Countries> Countries
		{
			get
			{
				return this.GetTable<Countries>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Authors")]
	public partial class Authors : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private string _Surname;
		
		private int _CountryId;
		
		private EntitySet<Books> _Books;
		
		private EntityRef<Countries> _Countries;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnSurnameChanging(string value);
    partial void OnSurnameChanged();
    partial void OnCountryIdChanging(int value);
    partial void OnCountryIdChanged();
    #endregion
		
		public Authors()
		{
			this._Books = new EntitySet<Books>(new Action<Books>(this.attach_Books), new Action<Books>(this.detach_Books));
			this._Countries = default(EntityRef<Countries>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(25) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Surname", DbType="NVarChar(25) NOT NULL", CanBeNull=false)]
		public string Surname
		{
			get
			{
				return this._Surname;
			}
			set
			{
				if ((this._Surname != value))
				{
					this.OnSurnameChanging(value);
					this.SendPropertyChanging();
					this._Surname = value;
					this.SendPropertyChanged("Surname");
					this.OnSurnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CountryId", DbType="Int NOT NULL")]
		public int CountryId
		{
			get
			{
				return this._CountryId;
			}
			set
			{
				if ((this._CountryId != value))
				{
					if (this._Countries.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCountryIdChanging(value);
					this.SendPropertyChanging();
					this._CountryId = value;
					this.SendPropertyChanged("CountryId");
					this.OnCountryIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Authors_Books", Storage="_Books", ThisKey="Id", OtherKey="AuthorId")]
		public EntitySet<Books> Books
		{
			get
			{
				return this._Books;
			}
			set
			{
				this._Books.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Countries_Authors", Storage="_Countries", ThisKey="CountryId", OtherKey="Id", IsForeignKey=true)]
		public Countries Countries
		{
			get
			{
				return this._Countries.Entity;
			}
			set
			{
				Countries previousValue = this._Countries.Entity;
				if (((previousValue != value) 
							|| (this._Countries.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Countries.Entity = null;
						previousValue.Authors.Remove(this);
					}
					this._Countries.Entity = value;
					if ((value != null))
					{
						value.Authors.Add(this);
						this._CountryId = value.Id;
					}
					else
					{
						this._CountryId = default(int);
					}
					this.SendPropertyChanged("Countries");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Books(Books entity)
		{
			this.SendPropertyChanging();
			entity.Authors = this;
		}
		
		private void detach_Books(Books entity)
		{
			this.SendPropertyChanging();
			entity.Authors = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Books")]
	public partial class Books : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private int _Pages;
		
		private int _AuthorId;
		
		private EntityRef<Authors> _Authors;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnPagesChanging(int value);
    partial void OnPagesChanged();
    partial void OnAuthorIdChanging(int value);
    partial void OnAuthorIdChanged();
    #endregion
		
		public Books()
		{
			this._Authors = default(EntityRef<Authors>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(25) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pages", DbType="Int NOT NULL")]
		public int Pages
		{
			get
			{
				return this._Pages;
			}
			set
			{
				if ((this._Pages != value))
				{
					this.OnPagesChanging(value);
					this.SendPropertyChanging();
					this._Pages = value;
					this.SendPropertyChanged("Pages");
					this.OnPagesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AuthorId", DbType="Int NOT NULL")]
		public int AuthorId
		{
			get
			{
				return this._AuthorId;
			}
			set
			{
				if ((this._AuthorId != value))
				{
					if (this._Authors.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnAuthorIdChanging(value);
					this.SendPropertyChanging();
					this._AuthorId = value;
					this.SendPropertyChanged("AuthorId");
					this.OnAuthorIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Authors_Books", Storage="_Authors", ThisKey="AuthorId", OtherKey="Id", IsForeignKey=true)]
		public Authors Authors
		{
			get
			{
				return this._Authors.Entity;
			}
			set
			{
				Authors previousValue = this._Authors.Entity;
				if (((previousValue != value) 
							|| (this._Authors.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Authors.Entity = null;
						previousValue.Books.Remove(this);
					}
					this._Authors.Entity = value;
					if ((value != null))
					{
						value.Books.Add(this);
						this._AuthorId = value.Id;
					}
					else
					{
						this._AuthorId = default(int);
					}
					this.SendPropertyChanged("Authors");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Countries")]
	public partial class Countries : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private EntitySet<Authors> _Authors;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public Countries()
		{
			this._Authors = new EntitySet<Authors>(new Action<Authors>(this.attach_Authors), new Action<Authors>(this.detach_Authors));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(25) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Countries_Authors", Storage="_Authors", ThisKey="Id", OtherKey="CountryId")]
		public EntitySet<Authors> Authors
		{
			get
			{
				return this._Authors;
			}
			set
			{
				this._Authors.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Authors(Authors entity)
		{
			this.SendPropertyChanging();
			entity.Countries = this;
		}
		
		private void detach_Authors(Authors entity)
		{
			this.SendPropertyChanging();
			entity.Countries = null;
		}
	}
}
#pragma warning restore 1591
