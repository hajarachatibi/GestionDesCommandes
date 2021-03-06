#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestionDesCommandes
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="MyDataBase")]
	public partial class DCDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertArticle(Article instance);
    partial void UpdateArticle(Article instance);
    partial void DeleteArticle(Article instance);
    partial void InsertComposition(Composition instance);
    partial void UpdateComposition(Composition instance);
    partial void DeleteComposition(Composition instance);
    partial void InsertMesCommande(MesCommande instance);
    partial void UpdateMesCommande(MesCommande instance);
    partial void DeleteMesCommande(MesCommande instance);
    #endregion
		
		public DCDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["MyDataBaseConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DCDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DCDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DCDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DCDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Article> Articles
		{
			get
			{
				return this.GetTable<Article>();
			}
		}
		
		public System.Data.Linq.Table<Composition> Compositions
		{
			get
			{
				return this.GetTable<Composition>();
			}
		}
		
		public System.Data.Linq.Table<MesCommande> MesCommandes
		{
			get
			{
				return this.GetTable<MesCommande>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Article")]
	public partial class Article : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CodeArt;
		
		private string _Libelle;
		
		private System.Nullable<double> _PU;
		
		private EntitySet<Composition> _Compositions;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCodeArtChanging(int value);
    partial void OnCodeArtChanged();
    partial void OnLibelleChanging(string value);
    partial void OnLibelleChanged();
    partial void OnPUChanging(System.Nullable<double> value);
    partial void OnPUChanged();
    #endregion
		
		public Article()
		{
			this._Compositions = new EntitySet<Composition>(new Action<Composition>(this.attach_Compositions), new Action<Composition>(this.detach_Compositions));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CodeArt", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int CodeArt
		{
			get
			{
				return this._CodeArt;
			}
			set
			{
				if ((this._CodeArt != value))
				{
					this.OnCodeArtChanging(value);
					this.SendPropertyChanging();
					this._CodeArt = value;
					this.SendPropertyChanged("CodeArt");
					this.OnCodeArtChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Libelle", DbType="VarChar(20)")]
		public string Libelle
		{
			get
			{
				return this._Libelle;
			}
			set
			{
				if ((this._Libelle != value))
				{
					this.OnLibelleChanging(value);
					this.SendPropertyChanging();
					this._Libelle = value;
					this.SendPropertyChanged("Libelle");
					this.OnLibelleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PU", DbType="Float")]
		public System.Nullable<double> PU
		{
			get
			{
				return this._PU;
			}
			set
			{
				if ((this._PU != value))
				{
					this.OnPUChanging(value);
					this.SendPropertyChanging();
					this._PU = value;
					this.SendPropertyChanged("PU");
					this.OnPUChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Article_Composition", Storage="_Compositions", ThisKey="CodeArt", OtherKey="CodeArt")]
		public EntitySet<Composition> Compositions
		{
			get
			{
				return this._Compositions;
			}
			set
			{
				this._Compositions.Assign(value);
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
		
		private void attach_Compositions(Composition entity)
		{
			this.SendPropertyChanging();
			entity.Article = this;
		}
		
		private void detach_Compositions(Composition entity)
		{
			this.SendPropertyChanging();
			entity.Article = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Composition")]
	public partial class Composition : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CodeCmp;
		
		private System.Nullable<int> _CodeArt;
		
		private System.Nullable<int> _CodeCmd;
		
		private System.Nullable<double> _Qte;
		
		private EntityRef<Article> _Article;
		
		private EntityRef<MesCommande> _MesCommande;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCodeCmpChanging(int value);
    partial void OnCodeCmpChanged();
    partial void OnCodeArtChanging(System.Nullable<int> value);
    partial void OnCodeArtChanged();
    partial void OnCodeCmdChanging(System.Nullable<int> value);
    partial void OnCodeCmdChanged();
    partial void OnQteChanging(System.Nullable<double> value);
    partial void OnQteChanged();
    #endregion
		
		public Composition()
		{
			this._Article = default(EntityRef<Article>);
			this._MesCommande = default(EntityRef<MesCommande>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CodeCmp", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int CodeCmp
		{
			get
			{
				return this._CodeCmp;
			}
			set
			{
				if ((this._CodeCmp != value))
				{
					this.OnCodeCmpChanging(value);
					this.SendPropertyChanging();
					this._CodeCmp = value;
					this.SendPropertyChanged("CodeCmp");
					this.OnCodeCmpChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CodeArt", DbType="Int")]
		public System.Nullable<int> CodeArt
		{
			get
			{
				return this._CodeArt;
			}
			set
			{
				if ((this._CodeArt != value))
				{
					if (this._Article.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCodeArtChanging(value);
					this.SendPropertyChanging();
					this._CodeArt = value;
					this.SendPropertyChanged("CodeArt");
					this.OnCodeArtChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CodeCmd", DbType="Int")]
		public System.Nullable<int> CodeCmd
		{
			get
			{
				return this._CodeCmd;
			}
			set
			{
				if ((this._CodeCmd != value))
				{
					if (this._MesCommande.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCodeCmdChanging(value);
					this.SendPropertyChanging();
					this._CodeCmd = value;
					this.SendPropertyChanged("CodeCmd");
					this.OnCodeCmdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Qte", DbType="Float")]
		public System.Nullable<double> Qte
		{
			get
			{
				return this._Qte;
			}
			set
			{
				if ((this._Qte != value))
				{
					this.OnQteChanging(value);
					this.SendPropertyChanging();
					this._Qte = value;
					this.SendPropertyChanged("Qte");
					this.OnQteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Article_Composition", Storage="_Article", ThisKey="CodeArt", OtherKey="CodeArt", IsForeignKey=true)]
		public Article Article
		{
			get
			{
				return this._Article.Entity;
			}
			set
			{
				Article previousValue = this._Article.Entity;
				if (((previousValue != value) 
							|| (this._Article.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Article.Entity = null;
						previousValue.Compositions.Remove(this);
					}
					this._Article.Entity = value;
					if ((value != null))
					{
						value.Compositions.Add(this);
						this._CodeArt = value.CodeArt;
					}
					else
					{
						this._CodeArt = default(Nullable<int>);
					}
					this.SendPropertyChanged("Article");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="MesCommande_Composition", Storage="_MesCommande", ThisKey="CodeCmd", OtherKey="CodeCmd", IsForeignKey=true)]
		public MesCommande MesCommande
		{
			get
			{
				return this._MesCommande.Entity;
			}
			set
			{
				MesCommande previousValue = this._MesCommande.Entity;
				if (((previousValue != value) 
							|| (this._MesCommande.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._MesCommande.Entity = null;
						previousValue.Compositions.Remove(this);
					}
					this._MesCommande.Entity = value;
					if ((value != null))
					{
						value.Compositions.Add(this);
						this._CodeCmd = value.CodeCmd;
					}
					else
					{
						this._CodeCmd = default(Nullable<int>);
					}
					this.SendPropertyChanged("MesCommande");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MesCommandes")]
	public partial class MesCommande : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CodeCmd;
		
		private System.Nullable<System.DateTime> _DateCmd;
		
		private EntitySet<Composition> _Compositions;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCodeCmdChanging(int value);
    partial void OnCodeCmdChanged();
    partial void OnDateCmdChanging(System.Nullable<System.DateTime> value);
    partial void OnDateCmdChanged();
    #endregion
		
		public MesCommande()
		{
			this._Compositions = new EntitySet<Composition>(new Action<Composition>(this.attach_Compositions), new Action<Composition>(this.detach_Compositions));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CodeCmd", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int CodeCmd
		{
			get
			{
				return this._CodeCmd;
			}
			set
			{
				if ((this._CodeCmd != value))
				{
					this.OnCodeCmdChanging(value);
					this.SendPropertyChanging();
					this._CodeCmd = value;
					this.SendPropertyChanged("CodeCmd");
					this.OnCodeCmdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateCmd", DbType="Date")]
		public System.Nullable<System.DateTime> DateCmd
		{
			get
			{
				return this._DateCmd;
			}
			set
			{
				if ((this._DateCmd != value))
				{
					this.OnDateCmdChanging(value);
					this.SendPropertyChanging();
					this._DateCmd = value;
					this.SendPropertyChanged("DateCmd");
					this.OnDateCmdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="MesCommande_Composition", Storage="_Compositions", ThisKey="CodeCmd", OtherKey="CodeCmd")]
		public EntitySet<Composition> Compositions
		{
			get
			{
				return this._Compositions;
			}
			set
			{
				this._Compositions.Assign(value);
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
		
		private void attach_Compositions(Composition entity)
		{
			this.SendPropertyChanging();
			entity.MesCommande = this;
		}
		
		private void detach_Compositions(Composition entity)
		{
			this.SendPropertyChanging();
			entity.MesCommande = null;
		}
	}
}
#pragma warning restore 1591
