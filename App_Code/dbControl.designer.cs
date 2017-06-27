﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Control_Citas")]
public partial class dbControlDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void InsertCategoria(Categoria instance);
  partial void UpdateCategoria(Categoria instance);
  partial void DeleteCategoria(Categoria instance);
  partial void InsertPermiso(Permiso instance);
  partial void UpdatePermiso(Permiso instance);
  partial void DeletePermiso(Permiso instance);
  partial void InsertPuesto(Puesto instance);
  partial void UpdatePuesto(Puesto instance);
  partial void DeletePuesto(Puesto instance);
  partial void InsertScreen(Screen instance);
  partial void UpdateScreen(Screen instance);
  partial void DeleteScreen(Screen instance);
  partial void InsertUsuario(Usuario instance);
  partial void UpdateUsuario(Usuario instance);
  partial void DeleteUsuario(Usuario instance);
  partial void InsertCita(Cita instance);
  partial void UpdateCita(Cita instance);
  partial void DeleteCita(Cita instance);
  #endregion
	
	public dbControlDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["Control_CitasConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public dbControlDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public dbControlDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public dbControlDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public dbControlDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<Categoria> Categorias
	{
		get
		{
			return this.GetTable<Categoria>();
		}
	}
	
	public System.Data.Linq.Table<Permiso> Permisos
	{
		get
		{
			return this.GetTable<Permiso>();
		}
	}
	
	public System.Data.Linq.Table<Puesto> Puestos
	{
		get
		{
			return this.GetTable<Puesto>();
		}
	}
	
	public System.Data.Linq.Table<Screen> Screens
	{
		get
		{
			return this.GetTable<Screen>();
		}
	}
	
	public System.Data.Linq.Table<Usuario> Usuarios
	{
		get
		{
			return this.GetTable<Usuario>();
		}
	}
	
	public System.Data.Linq.Table<Cita> Citas
	{
		get
		{
			return this.GetTable<Cita>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Categorias")]
public partial class Categoria : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _PKCategoria;
	
	private string _Nombre;
	
	private System.Nullable<int> _Tiempo;
	
	private EntitySet<Cita> _Citas;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPKCategoriaChanging(int value);
    partial void OnPKCategoriaChanged();
    partial void OnNombreChanging(string value);
    partial void OnNombreChanged();
    partial void OnTiempoChanging(System.Nullable<int> value);
    partial void OnTiempoChanged();
    #endregion
	
	public Categoria()
	{
		this._Citas = new EntitySet<Cita>(new Action<Cita>(this.attach_Citas), new Action<Cita>(this.detach_Citas));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PKCategoria", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int PKCategoria
	{
		get
		{
			return this._PKCategoria;
		}
		set
		{
			if ((this._PKCategoria != value))
			{
				this.OnPKCategoriaChanging(value);
				this.SendPropertyChanging();
				this._PKCategoria = value;
				this.SendPropertyChanged("PKCategoria");
				this.OnPKCategoriaChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(MAX)")]
	public string Nombre
	{
		get
		{
			return this._Nombre;
		}
		set
		{
			if ((this._Nombre != value))
			{
				this.OnNombreChanging(value);
				this.SendPropertyChanging();
				this._Nombre = value;
				this.SendPropertyChanged("Nombre");
				this.OnNombreChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tiempo", DbType="Int")]
	public System.Nullable<int> Tiempo
	{
		get
		{
			return this._Tiempo;
		}
		set
		{
			if ((this._Tiempo != value))
			{
				this.OnTiempoChanging(value);
				this.SendPropertyChanging();
				this._Tiempo = value;
				this.SendPropertyChanged("Tiempo");
				this.OnTiempoChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Categoria_Cita", Storage="_Citas", ThisKey="PKCategoria", OtherKey="FKCategoria")]
	public EntitySet<Cita> Citas
	{
		get
		{
			return this._Citas;
		}
		set
		{
			this._Citas.Assign(value);
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
	
	private void attach_Citas(Cita entity)
	{
		this.SendPropertyChanging();
		entity.Categoria = this;
	}
	
	private void detach_Citas(Cita entity)
	{
		this.SendPropertyChanging();
		entity.Categoria = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Permisos")]
public partial class Permiso : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _PKPermiso;
	
	private int _FKPuesto;
	
	private int _FKScreen;
	
	private EntitySet<Puesto> _Puestos;
	
	private EntityRef<Screen> _Screen;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPKPermisoChanging(int value);
    partial void OnPKPermisoChanged();
    partial void OnFKPuestoChanging(int value);
    partial void OnFKPuestoChanged();
    partial void OnFKScreenChanging(int value);
    partial void OnFKScreenChanged();
    #endregion
	
	public Permiso()
	{
		this._Puestos = new EntitySet<Puesto>(new Action<Puesto>(this.attach_Puestos), new Action<Puesto>(this.detach_Puestos));
		this._Screen = default(EntityRef<Screen>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PKPermiso", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int PKPermiso
	{
		get
		{
			return this._PKPermiso;
		}
		set
		{
			if ((this._PKPermiso != value))
			{
				this.OnPKPermisoChanging(value);
				this.SendPropertyChanging();
				this._PKPermiso = value;
				this.SendPropertyChanged("PKPermiso");
				this.OnPKPermisoChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FKPuesto", DbType="Int NOT NULL")]
	public int FKPuesto
	{
		get
		{
			return this._FKPuesto;
		}
		set
		{
			if ((this._FKPuesto != value))
			{
				this.OnFKPuestoChanging(value);
				this.SendPropertyChanging();
				this._FKPuesto = value;
				this.SendPropertyChanged("FKPuesto");
				this.OnFKPuestoChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FKScreen", DbType="Int NOT NULL")]
	public int FKScreen
	{
		get
		{
			return this._FKScreen;
		}
		set
		{
			if ((this._FKScreen != value))
			{
				if (this._Screen.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnFKScreenChanging(value);
				this.SendPropertyChanging();
				this._FKScreen = value;
				this.SendPropertyChanged("FKScreen");
				this.OnFKScreenChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Permiso_Puesto", Storage="_Puestos", ThisKey="PKPermiso", OtherKey="FKPermiso")]
	public EntitySet<Puesto> Puestos
	{
		get
		{
			return this._Puestos;
		}
		set
		{
			this._Puestos.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Screen_Permiso", Storage="_Screen", ThisKey="FKScreen", OtherKey="PKScreen", IsForeignKey=true)]
	public Screen Screen
	{
		get
		{
			return this._Screen.Entity;
		}
		set
		{
			Screen previousValue = this._Screen.Entity;
			if (((previousValue != value) 
						|| (this._Screen.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Screen.Entity = null;
					previousValue.Permisos.Remove(this);
				}
				this._Screen.Entity = value;
				if ((value != null))
				{
					value.Permisos.Add(this);
					this._FKScreen = value.PKScreen;
				}
				else
				{
					this._FKScreen = default(int);
				}
				this.SendPropertyChanged("Screen");
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
	
	private void attach_Puestos(Puesto entity)
	{
		this.SendPropertyChanging();
		entity.Permiso = this;
	}
	
	private void detach_Puestos(Puesto entity)
	{
		this.SendPropertyChanging();
		entity.Permiso = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Puestos")]
public partial class Puesto : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _PKPuesto;
	
	private string _Nombre;
	
	private System.Nullable<int> _FKPermiso;
	
	private EntitySet<Usuario> _Usuarios;
	
	private EntityRef<Permiso> _Permiso;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPKPuestoChanging(int value);
    partial void OnPKPuestoChanged();
    partial void OnNombreChanging(string value);
    partial void OnNombreChanged();
    partial void OnFKPermisoChanging(System.Nullable<int> value);
    partial void OnFKPermisoChanged();
    #endregion
	
	public Puesto()
	{
		this._Usuarios = new EntitySet<Usuario>(new Action<Usuario>(this.attach_Usuarios), new Action<Usuario>(this.detach_Usuarios));
		this._Permiso = default(EntityRef<Permiso>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PKPuesto", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int PKPuesto
	{
		get
		{
			return this._PKPuesto;
		}
		set
		{
			if ((this._PKPuesto != value))
			{
				this.OnPKPuestoChanging(value);
				this.SendPropertyChanging();
				this._PKPuesto = value;
				this.SendPropertyChanged("PKPuesto");
				this.OnPKPuestoChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(MAX)")]
	public string Nombre
	{
		get
		{
			return this._Nombre;
		}
		set
		{
			if ((this._Nombre != value))
			{
				this.OnNombreChanging(value);
				this.SendPropertyChanging();
				this._Nombre = value;
				this.SendPropertyChanged("Nombre");
				this.OnNombreChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FKPermiso", DbType="Int")]
	public System.Nullable<int> FKPermiso
	{
		get
		{
			return this._FKPermiso;
		}
		set
		{
			if ((this._FKPermiso != value))
			{
				if (this._Permiso.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnFKPermisoChanging(value);
				this.SendPropertyChanging();
				this._FKPermiso = value;
				this.SendPropertyChanged("FKPermiso");
				this.OnFKPermisoChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Puesto_Usuario", Storage="_Usuarios", ThisKey="PKPuesto", OtherKey="FKPuesto")]
	public EntitySet<Usuario> Usuarios
	{
		get
		{
			return this._Usuarios;
		}
		set
		{
			this._Usuarios.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Permiso_Puesto", Storage="_Permiso", ThisKey="FKPermiso", OtherKey="PKPermiso", IsForeignKey=true)]
	public Permiso Permiso
	{
		get
		{
			return this._Permiso.Entity;
		}
		set
		{
			Permiso previousValue = this._Permiso.Entity;
			if (((previousValue != value) 
						|| (this._Permiso.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Permiso.Entity = null;
					previousValue.Puestos.Remove(this);
				}
				this._Permiso.Entity = value;
				if ((value != null))
				{
					value.Puestos.Add(this);
					this._FKPermiso = value.PKPermiso;
				}
				else
				{
					this._FKPermiso = default(Nullable<int>);
				}
				this.SendPropertyChanged("Permiso");
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
	
	private void attach_Usuarios(Usuario entity)
	{
		this.SendPropertyChanging();
		entity.Puesto = this;
	}
	
	private void detach_Usuarios(Usuario entity)
	{
		this.SendPropertyChanging();
		entity.Puesto = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Screens")]
public partial class Screen : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _PKScreen;
	
	private string _Nombre;
	
	private string _URL;
	
	private System.Nullable<bool> _Available;
	
	private EntitySet<Permiso> _Permisos;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPKScreenChanging(int value);
    partial void OnPKScreenChanged();
    partial void OnNombreChanging(string value);
    partial void OnNombreChanged();
    partial void OnURLChanging(string value);
    partial void OnURLChanged();
    partial void OnAvailableChanging(System.Nullable<bool> value);
    partial void OnAvailableChanged();
    #endregion
	
	public Screen()
	{
		this._Permisos = new EntitySet<Permiso>(new Action<Permiso>(this.attach_Permisos), new Action<Permiso>(this.detach_Permisos));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PKScreen", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int PKScreen
	{
		get
		{
			return this._PKScreen;
		}
		set
		{
			if ((this._PKScreen != value))
			{
				this.OnPKScreenChanging(value);
				this.SendPropertyChanging();
				this._PKScreen = value;
				this.SendPropertyChanged("PKScreen");
				this.OnPKScreenChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(MAX)")]
	public string Nombre
	{
		get
		{
			return this._Nombre;
		}
		set
		{
			if ((this._Nombre != value))
			{
				this.OnNombreChanging(value);
				this.SendPropertyChanging();
				this._Nombre = value;
				this.SendPropertyChanged("Nombre");
				this.OnNombreChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_URL", DbType="VarChar(MAX)")]
	public string URL
	{
		get
		{
			return this._URL;
		}
		set
		{
			if ((this._URL != value))
			{
				this.OnURLChanging(value);
				this.SendPropertyChanging();
				this._URL = value;
				this.SendPropertyChanged("URL");
				this.OnURLChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Available", DbType="Bit")]
	public System.Nullable<bool> Available
	{
		get
		{
			return this._Available;
		}
		set
		{
			if ((this._Available != value))
			{
				this.OnAvailableChanging(value);
				this.SendPropertyChanging();
				this._Available = value;
				this.SendPropertyChanged("Available");
				this.OnAvailableChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Screen_Permiso", Storage="_Permisos", ThisKey="PKScreen", OtherKey="FKScreen")]
	public EntitySet<Permiso> Permisos
	{
		get
		{
			return this._Permisos;
		}
		set
		{
			this._Permisos.Assign(value);
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
	
	private void attach_Permisos(Permiso entity)
	{
		this.SendPropertyChanging();
		entity.Screen = this;
	}
	
	private void detach_Permisos(Permiso entity)
	{
		this.SendPropertyChanging();
		entity.Screen = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Usuarios")]
public partial class Usuario : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _PKUsuario;
	
	private string _Nombre;
	
	private string _ApellidoP;
	
	private string _ApellidoM;
	
	private int _NEmpleado;
	
	private string _Contraseña;
	
	private System.Nullable<int> _FKPuesto;
	
	private EntitySet<Cita> _Citas;
	
	private EntitySet<Cita> _Citas1;
	
	private EntityRef<Puesto> _Puesto;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPKUsuarioChanging(int value);
    partial void OnPKUsuarioChanged();
    partial void OnNombreChanging(string value);
    partial void OnNombreChanged();
    partial void OnApellidoPChanging(string value);
    partial void OnApellidoPChanged();
    partial void OnApellidoMChanging(string value);
    partial void OnApellidoMChanged();
    partial void OnNEmpleadoChanging(int value);
    partial void OnNEmpleadoChanged();
    partial void OnContraseñaChanging(string value);
    partial void OnContraseñaChanged();
    partial void OnFKPuestoChanging(System.Nullable<int> value);
    partial void OnFKPuestoChanged();
    #endregion
	
	public Usuario()
	{
		this._Citas = new EntitySet<Cita>(new Action<Cita>(this.attach_Citas), new Action<Cita>(this.detach_Citas));
		this._Citas1 = new EntitySet<Cita>(new Action<Cita>(this.attach_Citas1), new Action<Cita>(this.detach_Citas1));
		this._Puesto = default(EntityRef<Puesto>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PKUsuario", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int PKUsuario
	{
		get
		{
			return this._PKUsuario;
		}
		set
		{
			if ((this._PKUsuario != value))
			{
				this.OnPKUsuarioChanging(value);
				this.SendPropertyChanging();
				this._PKUsuario = value;
				this.SendPropertyChanged("PKUsuario");
				this.OnPKUsuarioChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(MAX)")]
	public string Nombre
	{
		get
		{
			return this._Nombre;
		}
		set
		{
			if ((this._Nombre != value))
			{
				this.OnNombreChanging(value);
				this.SendPropertyChanging();
				this._Nombre = value;
				this.SendPropertyChanged("Nombre");
				this.OnNombreChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ApellidoP", DbType="VarChar(MAX)")]
	public string ApellidoP
	{
		get
		{
			return this._ApellidoP;
		}
		set
		{
			if ((this._ApellidoP != value))
			{
				this.OnApellidoPChanging(value);
				this.SendPropertyChanging();
				this._ApellidoP = value;
				this.SendPropertyChanged("ApellidoP");
				this.OnApellidoPChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ApellidoM", DbType="VarChar(MAX)")]
	public string ApellidoM
	{
		get
		{
			return this._ApellidoM;
		}
		set
		{
			if ((this._ApellidoM != value))
			{
				this.OnApellidoMChanging(value);
				this.SendPropertyChanging();
				this._ApellidoM = value;
				this.SendPropertyChanged("ApellidoM");
				this.OnApellidoMChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NEmpleado", DbType="Int NOT NULL")]
	public int NEmpleado
	{
		get
		{
			return this._NEmpleado;
		}
		set
		{
			if ((this._NEmpleado != value))
			{
				this.OnNEmpleadoChanging(value);
				this.SendPropertyChanging();
				this._NEmpleado = value;
				this.SendPropertyChanged("NEmpleado");
				this.OnNEmpleadoChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Contraseña", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
	public string Contraseña
	{
		get
		{
			return this._Contraseña;
		}
		set
		{
			if ((this._Contraseña != value))
			{
				this.OnContraseñaChanging(value);
				this.SendPropertyChanging();
				this._Contraseña = value;
				this.SendPropertyChanged("Contraseña");
				this.OnContraseñaChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FKPuesto", DbType="Int")]
	public System.Nullable<int> FKPuesto
	{
		get
		{
			return this._FKPuesto;
		}
		set
		{
			if ((this._FKPuesto != value))
			{
				if (this._Puesto.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnFKPuestoChanging(value);
				this.SendPropertyChanging();
				this._FKPuesto = value;
				this.SendPropertyChanged("FKPuesto");
				this.OnFKPuestoChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Usuario_Cita", Storage="_Citas", ThisKey="PKUsuario", OtherKey="FKUsuario")]
	public EntitySet<Cita> Citas
	{
		get
		{
			return this._Citas;
		}
		set
		{
			this._Citas.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Usuario_Cita1", Storage="_Citas1", ThisKey="NEmpleado", OtherKey="FKNControl")]
	public EntitySet<Cita> Citas1
	{
		get
		{
			return this._Citas1;
		}
		set
		{
			this._Citas1.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Puesto_Usuario", Storage="_Puesto", ThisKey="FKPuesto", OtherKey="PKPuesto", IsForeignKey=true)]
	public Puesto Puesto
	{
		get
		{
			return this._Puesto.Entity;
		}
		set
		{
			Puesto previousValue = this._Puesto.Entity;
			if (((previousValue != value) 
						|| (this._Puesto.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Puesto.Entity = null;
					previousValue.Usuarios.Remove(this);
				}
				this._Puesto.Entity = value;
				if ((value != null))
				{
					value.Usuarios.Add(this);
					this._FKPuesto = value.PKPuesto;
				}
				else
				{
					this._FKPuesto = default(Nullable<int>);
				}
				this.SendPropertyChanged("Puesto");
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
	
	private void attach_Citas(Cita entity)
	{
		this.SendPropertyChanging();
		entity.Usuario = this;
	}
	
	private void detach_Citas(Cita entity)
	{
		this.SendPropertyChanging();
		entity.Usuario = null;
	}
	
	private void attach_Citas1(Cita entity)
	{
		this.SendPropertyChanging();
		entity.Usuario1 = this;
	}
	
	private void detach_Citas1(Cita entity)
	{
		this.SendPropertyChanging();
		entity.Usuario1 = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Citas")]
public partial class Cita : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _PKNCita;
	
	private int _FKNControl;
	
	private int _FKCategoria;
	
	private System.Nullable<System.DateTime> _Date;
	
	private System.Nullable<bool> _Atendido;
	
	private System.Nullable<int> _FKUsuario;
	
	private EntityRef<Usuario> _Usuario;
	
	private EntityRef<Categoria> _Categoria;
	
	private EntityRef<Usuario> _Usuario1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPKNCitaChanging(int value);
    partial void OnPKNCitaChanged();
    partial void OnFKNControlChanging(int value);
    partial void OnFKNControlChanged();
    partial void OnFKCategoriaChanging(int value);
    partial void OnFKCategoriaChanged();
    partial void OnDateChanging(System.Nullable<System.DateTime> value);
    partial void OnDateChanged();
    partial void OnAtendidoChanging(System.Nullable<bool> value);
    partial void OnAtendidoChanged();
    partial void OnFKUsuarioChanging(System.Nullable<int> value);
    partial void OnFKUsuarioChanged();
    #endregion
	
	public Cita()
	{
		this._Usuario = default(EntityRef<Usuario>);
		this._Categoria = default(EntityRef<Categoria>);
		this._Usuario1 = default(EntityRef<Usuario>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PKNCita", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int PKNCita
	{
		get
		{
			return this._PKNCita;
		}
		set
		{
			if ((this._PKNCita != value))
			{
				this.OnPKNCitaChanging(value);
				this.SendPropertyChanging();
				this._PKNCita = value;
				this.SendPropertyChanged("PKNCita");
				this.OnPKNCitaChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FKNControl", DbType="Int NOT NULL")]
	public int FKNControl
	{
		get
		{
			return this._FKNControl;
		}
		set
		{
			if ((this._FKNControl != value))
			{
				if (this._Usuario1.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnFKNControlChanging(value);
				this.SendPropertyChanging();
				this._FKNControl = value;
				this.SendPropertyChanged("FKNControl");
				this.OnFKNControlChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FKCategoria", DbType="Int NOT NULL")]
	public int FKCategoria
	{
		get
		{
			return this._FKCategoria;
		}
		set
		{
			if ((this._FKCategoria != value))
			{
				if (this._Categoria.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnFKCategoriaChanging(value);
				this.SendPropertyChanging();
				this._FKCategoria = value;
				this.SendPropertyChanged("FKCategoria");
				this.OnFKCategoriaChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="DateTime")]
	public System.Nullable<System.DateTime> Date
	{
		get
		{
			return this._Date;
		}
		set
		{
			if ((this._Date != value))
			{
				this.OnDateChanging(value);
				this.SendPropertyChanging();
				this._Date = value;
				this.SendPropertyChanged("Date");
				this.OnDateChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Atendido", DbType="Bit")]
	public System.Nullable<bool> Atendido
	{
		get
		{
			return this._Atendido;
		}
		set
		{
			if ((this._Atendido != value))
			{
				this.OnAtendidoChanging(value);
				this.SendPropertyChanging();
				this._Atendido = value;
				this.SendPropertyChanged("Atendido");
				this.OnAtendidoChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FKUsuario", DbType="Int")]
	public System.Nullable<int> FKUsuario
	{
		get
		{
			return this._FKUsuario;
		}
		set
		{
			if ((this._FKUsuario != value))
			{
				if (this._Usuario.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnFKUsuarioChanging(value);
				this.SendPropertyChanging();
				this._FKUsuario = value;
				this.SendPropertyChanged("FKUsuario");
				this.OnFKUsuarioChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Usuario_Cita", Storage="_Usuario", ThisKey="FKUsuario", OtherKey="PKUsuario", IsForeignKey=true)]
	public Usuario Usuario
	{
		get
		{
			return this._Usuario.Entity;
		}
		set
		{
			Usuario previousValue = this._Usuario.Entity;
			if (((previousValue != value) 
						|| (this._Usuario.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Usuario.Entity = null;
					previousValue.Citas.Remove(this);
				}
				this._Usuario.Entity = value;
				if ((value != null))
				{
					value.Citas.Add(this);
					this._FKUsuario = value.PKUsuario;
				}
				else
				{
					this._FKUsuario = default(Nullable<int>);
				}
				this.SendPropertyChanged("Usuario");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Categoria_Cita", Storage="_Categoria", ThisKey="FKCategoria", OtherKey="PKCategoria", IsForeignKey=true)]
	public Categoria Categoria
	{
		get
		{
			return this._Categoria.Entity;
		}
		set
		{
			Categoria previousValue = this._Categoria.Entity;
			if (((previousValue != value) 
						|| (this._Categoria.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Categoria.Entity = null;
					previousValue.Citas.Remove(this);
				}
				this._Categoria.Entity = value;
				if ((value != null))
				{
					value.Citas.Add(this);
					this._FKCategoria = value.PKCategoria;
				}
				else
				{
					this._FKCategoria = default(int);
				}
				this.SendPropertyChanged("Categoria");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Usuario_Cita1", Storage="_Usuario1", ThisKey="FKNControl", OtherKey="NEmpleado", IsForeignKey=true)]
	public Usuario Usuario1
	{
		get
		{
			return this._Usuario1.Entity;
		}
		set
		{
			Usuario previousValue = this._Usuario1.Entity;
			if (((previousValue != value) 
						|| (this._Usuario1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Usuario1.Entity = null;
					previousValue.Citas1.Remove(this);
				}
				this._Usuario1.Entity = value;
				if ((value != null))
				{
					value.Citas1.Add(this);
					this._FKNControl = value.NEmpleado;
				}
				else
				{
					this._FKNControl = default(int);
				}
				this.SendPropertyChanged("Usuario1");
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
#pragma warning restore 1591