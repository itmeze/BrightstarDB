﻿ 

// -----------------------------------------------------------------------
// <autogenerated>
//    This code was generated from a template.
//
//    Changes to this file may cause incorrect behaviour and will be lost
//    if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using BrightstarDB.Client;
using BrightstarDB.EntityFramework;

namespace BrightstarDB.Samples.EntityFramework.ChangeTracking 
{
    public partial class MyEntityContext : BrightstarEntityContext {
    	private static readonly EntityMappingStore TypeMappings;
    	
    	static MyEntityContext() 
    	{
    		TypeMappings = new EntityMappingStore();
    		var provider = new ReflectionMappingProvider();
    		provider.AddMappingsForType(TypeMappings, typeof(BrightstarDB.Samples.EntityFramework.ChangeTracking.IArticle));
    		TypeMappings.AddImplMapping<BrightstarDB.Samples.EntityFramework.ChangeTracking.IArticle, BrightstarDB.Samples.EntityFramework.ChangeTracking.Article>();
    		provider.AddMappingsForType(TypeMappings, typeof(BrightstarDB.Samples.EntityFramework.ChangeTracking.ITrackable));
    		TypeMappings.AddImplMapping<BrightstarDB.Samples.EntityFramework.ChangeTracking.ITrackable, BrightstarDB.Samples.EntityFramework.ChangeTracking.Trackable>();
    	}
    	
    	/// <summary>
    	/// Initialize a new entity context using the specified Brightstar
    	/// Data Object Store connection
    	/// </summary>
    	/// <param name="dataObjectStore">The connection to the Brightstar Data Object Store that will provide the entity objects</param>
    	public MyEntityContext(IDataObjectStore dataObjectStore) : base(TypeMappings, dataObjectStore)
    	{
    		InitializeContext();
    	}
    
    	/// <summary>
    	/// Initialize a new entity context using the specified Brightstar
    	/// connection string
    	/// </summary>
    	/// <param name="connectionString">The connection to be used to connect to an existing BrightstarDB store</param>
    	/// <param name="enableOptimisticLocking">OPTIONAL: If set to true optmistic locking will be applied to all entity updates</param>
    	public MyEntityContext(string connectionString, bool? enableOptimisticLocking=null) : base(TypeMappings, connectionString, enableOptimisticLocking)
    	{
    		InitializeContext();
    	}
    
    	/// <summary>
    	/// Initialize a new entity context using the specified Brightstar
    	/// connection string retrieved from the configuration.
    	/// </summary>
    	public MyEntityContext() : base(TypeMappings)
    	{
    		InitializeContext();
    	}
    	
    	private void InitializeContext() 
    	{
    		Articles = 	new BrightstarEntitySet<BrightstarDB.Samples.EntityFramework.ChangeTracking.IArticle>(this);
    		Trackables = 	new BrightstarEntitySet<BrightstarDB.Samples.EntityFramework.ChangeTracking.ITrackable>(this);
    	}
    	
    	internal IEntitySet<BrightstarDB.Samples.EntityFramework.ChangeTracking.IArticle> Articles
    	{
    		get; private set;
    	}
    	
    	internal IEntitySet<BrightstarDB.Samples.EntityFramework.ChangeTracking.ITrackable> Trackables
    	{
    		get; private set;
    	}
    	
    }
}
namespace BrightstarDB.Samples.EntityFramework.ChangeTracking 
{
    
    internal partial class Article : BrightstarEntityObject, IArticle 
    {
    	public Article(BrightstarEntityContext context, IDataObject dataObject) : base(context, dataObject) { }
    	public Article() : base() { }
    	public System.String Id { get {return GetIdentity(); } set { SetIdentity(value); } }
    	#region Implementation of BrightstarDB.Samples.EntityFramework.ChangeTracking.IArticle
    
    	public System.String Title
    	{
            		get { return GetRelatedProperty<System.String>("Title"); }
            		set { SetRelatedProperty("Title", value); }
    	}
    
    	public System.String BodyText
    	{
            		get { return GetRelatedProperty<System.String>("BodyText"); }
            		set { SetRelatedProperty("BodyText", value); }
    	}
    	#endregion
    	#region Implementation of BrightstarDB.Samples.EntityFramework.ChangeTracking.ITrackable
    
    	public System.DateTime Created
    	{
            		get { return GetRelatedProperty<System.DateTime>("Created"); }
            		set { SetRelatedProperty("Created", value); }
    	}
    
    	public System.DateTime LastModified
    	{
            		get { return GetRelatedProperty<System.DateTime>("LastModified"); }
            		set { SetRelatedProperty("LastModified", value); }
    	}
    	#endregion
    }
}
namespace BrightstarDB.Samples.EntityFramework.ChangeTracking 
{
    
    internal partial class Trackable : BrightstarEntityObject, ITrackable 
    {
    	public Trackable(BrightstarEntityContext context, IDataObject dataObject) : base(context, dataObject) { }
    	public Trackable() : base() { }
    	#region Implementation of BrightstarDB.Samples.EntityFramework.ChangeTracking.ITrackable
    
    	public System.DateTime Created
    	{
            		get { return GetRelatedProperty<System.DateTime>("Created"); }
            		set { SetRelatedProperty("Created", value); }
    	}
    
    	public System.DateTime LastModified
    	{
            		get { return GetRelatedProperty<System.DateTime>("LastModified"); }
            		set { SetRelatedProperty("LastModified", value); }
    	}
    	#endregion
    }
}
