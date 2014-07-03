using System;

using Mindscape.LightSpeed;
using Mindscape.LightSpeed.Validation;
using Mindscape.LightSpeed.Linq;

namespace OctopusApp.Plumbing
{
  [Serializable]
  [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
  [System.ComponentModel.DataObject]
  public partial class DeploymentComponent : Entity<int>
  {
    #region Fields
  
    [Column("project_id")]
    private string _projectId;
    [Column("project_name")]
    [ValidatePresence]
    [ValidateLength(0, 100)]
    private string _projectName;
    [Column("project_description")]
    [ValidatePresence]
    [ValidateLength(0, 1000)]
    private string _projectDescription;
    [Column("release_version")]
    [ValidatePresence]
    [ValidateLength(0, 100)]
    private string _releaseVersion;
    [Column("release_id")]
    [ValidatePresence]
    [ValidateLength(0, 100)]
    private string _releaseId;

    #endregion
    
    #region Field attribute and view names
    
    /// <summary>Identifies the ProjectId entity attribute.</summary>
    public const string ProjectIdField = "ProjectId";
    /// <summary>Identifies the ProjectName entity attribute.</summary>
    public const string ProjectNameField = "ProjectName";
    /// <summary>Identifies the ProjectDescription entity attribute.</summary>
    public const string ProjectDescriptionField = "ProjectDescription";
    /// <summary>Identifies the ReleaseVersion entity attribute.</summary>
    public const string ReleaseVersionField = "ReleaseVersion";
    /// <summary>Identifies the ReleaseId entity attribute.</summary>
    public const string ReleaseIdField = "ReleaseId";


    #endregion
    
    #region Relationships

    [ReverseAssociation("DeploymentComponent")]
    private readonly EntityCollection<RecipeComponent> _recipeComponents = new EntityCollection<RecipeComponent>();

    private ThroughAssociation<RecipeComponent, OctopusRecipe> _octopusRecipes;

    #endregion
    
    #region Properties

    [System.Diagnostics.DebuggerNonUserCode]
    public EntityCollection<RecipeComponent> RecipeComponents
    {
      get { return Get(_recipeComponents); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public ThroughAssociation<RecipeComponent, OctopusRecipe> OctopusRecipes
    {
      get
      {
        if (_octopusRecipes == null)
        {
          _octopusRecipes = new ThroughAssociation<RecipeComponent, OctopusRecipe>(_recipeComponents);
        }
        return Get(_octopusRecipes);
      }
    }
    

    [System.Diagnostics.DebuggerNonUserCode]
    public string ProjectId
    {
      get { return Get(ref _projectId, "ProjectId"); }
      set { Set(ref _projectId, value, "ProjectId"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public string ProjectName
    {
      get { return Get(ref _projectName, "ProjectName"); }
      set { Set(ref _projectName, value, "ProjectName"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public string ProjectDescription
    {
      get { return Get(ref _projectDescription, "ProjectDescription"); }
      set { Set(ref _projectDescription, value, "ProjectDescription"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public string ReleaseVersion
    {
      get { return Get(ref _releaseVersion, "ReleaseVersion"); }
      set { Set(ref _releaseVersion, value, "ReleaseVersion"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public string ReleaseId
    {
      get { return Get(ref _releaseId, "ReleaseId"); }
      set { Set(ref _releaseId, value, "ReleaseId"); }
    }

    #endregion
  }


  [Serializable]
  [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
  [System.ComponentModel.DataObject]
  [Table("RecipeComponents")]
  public partial class RecipeComponent : Entity<int>
  {
    #region Fields
  
    [Column("DeploymentComponent_id")]
    private int _deploymentComponentId;
    [Column("OctopusRecipe_id")]
    private int _octopusRecipeId;

    #endregion
    
    #region Field attribute and view names
    
    /// <summary>Identifies the DeploymentComponentId entity attribute.</summary>
    public const string DeploymentComponentIdField = "DeploymentComponentId";
    /// <summary>Identifies the OctopusRecipeId entity attribute.</summary>
    public const string OctopusRecipeIdField = "OctopusRecipeId";


    #endregion
    
    #region Relationships

    [ReverseAssociation("RecipeComponents")]
    private readonly EntityHolder<DeploymentComponent> _deploymentComponent = new EntityHolder<DeploymentComponent>();
    [ReverseAssociation("RecipeComponents")]
    private readonly EntityHolder<OctopusRecipe> _octopusRecipe = new EntityHolder<OctopusRecipe>();


    #endregion
    
    #region Properties

    [System.Diagnostics.DebuggerNonUserCode]
    public DeploymentComponent DeploymentComponent
    {
      get { return Get(_deploymentComponent); }
      set { Set(_deploymentComponent, value); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public OctopusRecipe OctopusRecipe
    {
      get { return Get(_octopusRecipe); }
      set { Set(_octopusRecipe, value); }
    }


    /// <summary>Gets or sets the ID for the <see cref="DeploymentComponent" /> property.</summary>
    [System.Diagnostics.DebuggerNonUserCode]
    public int DeploymentComponentId
    {
      get { return Get(ref _deploymentComponentId, "DeploymentComponentId"); }
      set { Set(ref _deploymentComponentId, value, "DeploymentComponentId"); }
    }

    /// <summary>Gets or sets the ID for the <see cref="OctopusRecipe" /> property.</summary>
    [System.Diagnostics.DebuggerNonUserCode]
    public int OctopusRecipeId
    {
      get { return Get(ref _octopusRecipeId, "OctopusRecipeId"); }
      set { Set(ref _octopusRecipeId, value, "OctopusRecipeId"); }
    }

    #endregion
  }


  [Serializable]
  [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
  [System.ComponentModel.DataObject]
  public partial class OctopusRecipe : Entity<int>
  {
    #region Fields
  
    [ValidatePresence]
    [ValidateLength(0, 100)]
    private string _name;
    [Column("source_environment_id")]
    [ValidateLength(0, 50)]
    private string _sourceEnvironmentId;
    [Column("source_environment_name")]
    [ValidateLength(0, 100)]
    private string _sourceEnvironmentName;
    [Column("date_created")]
    private System.DateTime _dateCreated;
    [Column("created_by")]
    [ValidateLength(0, 50)]
    private string _createdBy;
    [Column("recipe_id")]
    [ValidatePresence]
    [ValidateLength(0, 100)]
    private string _recipeId;

    #endregion
    
    #region Field attribute and view names
    
    /// <summary>Identifies the Name entity attribute.</summary>
    public const string NameField = "Name";
    /// <summary>Identifies the SourceEnvironmentId entity attribute.</summary>
    public const string SourceEnvironmentIdField = "SourceEnvironmentId";
    /// <summary>Identifies the SourceEnvironmentName entity attribute.</summary>
    public const string SourceEnvironmentNameField = "SourceEnvironmentName";
    /// <summary>Identifies the DateCreated entity attribute.</summary>
    public const string DateCreatedField = "DateCreated";
    /// <summary>Identifies the CreatedBy entity attribute.</summary>
    public const string CreatedByField = "CreatedBy";
    /// <summary>Identifies the RecipeId entity attribute.</summary>
    public const string RecipeIdField = "RecipeId";


    #endregion
    
    #region Relationships

    [ReverseAssociation("OctopusRecipe")]
    private readonly EntityCollection<RecipeComponent> _recipeComponents = new EntityCollection<RecipeComponent>();

    private ThroughAssociation<RecipeComponent, DeploymentComponent> _deploymentComponents;

    #endregion
    
    #region Properties

    [System.Diagnostics.DebuggerNonUserCode]
    public EntityCollection<RecipeComponent> RecipeComponents
    {
      get { return Get(_recipeComponents); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public ThroughAssociation<RecipeComponent, DeploymentComponent> DeploymentComponents
    {
      get
      {
        if (_deploymentComponents == null)
        {
          _deploymentComponents = new ThroughAssociation<RecipeComponent, DeploymentComponent>(_recipeComponents);
        }
        return Get(_deploymentComponents);
      }
    }
    

    [System.Diagnostics.DebuggerNonUserCode]
    public string Name
    {
      get { return Get(ref _name, "Name"); }
      set { Set(ref _name, value, "Name"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public string SourceEnvironmentId
    {
      get { return Get(ref _sourceEnvironmentId, "SourceEnvironmentId"); }
      set { Set(ref _sourceEnvironmentId, value, "SourceEnvironmentId"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public string SourceEnvironmentName
    {
      get { return Get(ref _sourceEnvironmentName, "SourceEnvironmentName"); }
      set { Set(ref _sourceEnvironmentName, value, "SourceEnvironmentName"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public System.DateTime DateCreated
    {
      get { return Get(ref _dateCreated, "DateCreated"); }
      set { Set(ref _dateCreated, value, "DateCreated"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public string CreatedBy
    {
      get { return Get(ref _createdBy, "CreatedBy"); }
      set { Set(ref _createdBy, value, "CreatedBy"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public string RecipeId
    {
      get { return Get(ref _recipeId, "RecipeId"); }
      set { Set(ref _recipeId, value, "RecipeId"); }
    }

    #endregion
  }




  /// <summary>
  /// Provides a strong-typed unit of work for working with the OctopusApp model.
  /// </summary>
  [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
  public partial class OctopusAppUnitOfWork : Mindscape.LightSpeed.UnitOfWork
  {

    public System.Linq.IQueryable<DeploymentComponent> DeploymentComponents
    {
      get { return this.Query<DeploymentComponent>(); }
    }
    
    public System.Linq.IQueryable<RecipeComponent> RecipeComponents
    {
      get { return this.Query<RecipeComponent>(); }
    }
    
    public System.Linq.IQueryable<OctopusRecipe> OctopusRecipes
    {
      get { return this.Query<OctopusRecipe>(); }
    }
    
  }

}
