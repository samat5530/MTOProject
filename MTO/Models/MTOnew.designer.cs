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

namespace MTO.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="MTO")]
	public partial class MTOnewDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Определения метода расширяемости
    partial void OnCreated();
    partial void InsertQuestions(Questions instance);
    partial void UpdateQuestions(Questions instance);
    partial void DeleteQuestions(Questions instance);
    partial void InsertQuestionTypes(QuestionTypes instance);
    partial void UpdateQuestionTypes(QuestionTypes instance);
    partial void DeleteQuestionTypes(QuestionTypes instance);
    partial void InsertUsers(Users instance);
    partial void UpdateUsers(Users instance);
    partial void DeleteUsers(Users instance);
    partial void InsertUserTypes(UserTypes instance);
    partial void UpdateUserTypes(UserTypes instance);
    partial void DeleteUserTypes(UserTypes instance);
    #endregion
		
		public MTOnewDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["MTOConnectionString1"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public MTOnewDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MTOnewDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MTOnewDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MTOnewDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<InputTrueAnswers> InputTrueAnswers
		{
			get
			{
				return this.GetTable<InputTrueAnswers>();
			}
		}
		
		public System.Data.Linq.Table<CheckboxAnswers> CheckboxAnswers
		{
			get
			{
				return this.GetTable<CheckboxAnswers>();
			}
		}
		
		public System.Data.Linq.Table<OptionAnswers> OptionAnswers
		{
			get
			{
				return this.GetTable<OptionAnswers>();
			}
		}
		
		public System.Data.Linq.Table<Questions> Questions
		{
			get
			{
				return this.GetTable<Questions>();
			}
		}
		
		public System.Data.Linq.Table<QuestionTypes> QuestionTypes
		{
			get
			{
				return this.GetTable<QuestionTypes>();
			}
		}
		
		public System.Data.Linq.Table<RadioAnswers> RadioAnswers
		{
			get
			{
				return this.GetTable<RadioAnswers>();
			}
		}
		
		public System.Data.Linq.Table<StudentScores> StudentScores
		{
			get
			{
				return this.GetTable<StudentScores>();
			}
		}
		
		public System.Data.Linq.Table<TeacherLections> TeacherLections
		{
			get
			{
				return this.GetTable<TeacherLections>();
			}
		}
		
		public System.Data.Linq.Table<Users> Users
		{
			get
			{
				return this.GetTable<Users>();
			}
		}
		
		public System.Data.Linq.Table<UserTypes> UserTypes
		{
			get
			{
				return this.GetTable<UserTypes>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.InputTrueAnswers")]
	public partial class InputTrueAnswers
	{
		
		private int _QuetionID;
		
		private string _InputTrueAnswer;
		
		public InputTrueAnswers()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QuetionID", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int QuetionID
		{
			get
			{
				return this._QuetionID;
			}
			set
			{
				if ((this._QuetionID != value))
				{
					this._QuetionID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InputTrueAnswer", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string InputTrueAnswer
		{
			get
			{
				return this._InputTrueAnswer;
			}
			set
			{
				if ((this._InputTrueAnswer != value))
				{
					this._InputTrueAnswer = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CheckboxAnswers")]
	public partial class CheckboxAnswers
	{
		
		private int _QuestionID;
		
		private string _Checkbox1;
		
		private string _Checkbox2;
		
		private string _Checkbox3;
		
		private string _Checkbox4;
		
		private string _Checkbox5;
		
		public CheckboxAnswers()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QuestionID", DbType="Int NOT NULL")]
		public int QuestionID
		{
			get
			{
				return this._QuestionID;
			}
			set
			{
				if ((this._QuestionID != value))
				{
					this._QuestionID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Checkbox1", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Checkbox1
		{
			get
			{
				return this._Checkbox1;
			}
			set
			{
				if ((this._Checkbox1 != value))
				{
					this._Checkbox1 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Checkbox2", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Checkbox2
		{
			get
			{
				return this._Checkbox2;
			}
			set
			{
				if ((this._Checkbox2 != value))
				{
					this._Checkbox2 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Checkbox3", DbType="NVarChar(50)")]
		public string Checkbox3
		{
			get
			{
				return this._Checkbox3;
			}
			set
			{
				if ((this._Checkbox3 != value))
				{
					this._Checkbox3 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Checkbox4", DbType="NVarChar(50)")]
		public string Checkbox4
		{
			get
			{
				return this._Checkbox4;
			}
			set
			{
				if ((this._Checkbox4 != value))
				{
					this._Checkbox4 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Checkbox5", DbType="NVarChar(50)")]
		public string Checkbox5
		{
			get
			{
				return this._Checkbox5;
			}
			set
			{
				if ((this._Checkbox5 != value))
				{
					this._Checkbox5 = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.OptionAnswers")]
	public partial class OptionAnswers
	{
		
		private int _QuestionID;
		
		private string _ExpA;
		
		private string _ExpB;
		
		private string _ExpC;
		
		private string _ExpD;
		
		private string _OptionA;
		
		private string _OptionB;
		
		private string _OptionC;
		
		private string _OptionD;
		
		public OptionAnswers()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QuestionID", DbType="Int NOT NULL")]
		public int QuestionID
		{
			get
			{
				return this._QuestionID;
			}
			set
			{
				if ((this._QuestionID != value))
				{
					this._QuestionID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ExpA", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string ExpA
		{
			get
			{
				return this._ExpA;
			}
			set
			{
				if ((this._ExpA != value))
				{
					this._ExpA = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ExpB", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string ExpB
		{
			get
			{
				return this._ExpB;
			}
			set
			{
				if ((this._ExpB != value))
				{
					this._ExpB = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ExpC", DbType="NVarChar(50)")]
		public string ExpC
		{
			get
			{
				return this._ExpC;
			}
			set
			{
				if ((this._ExpC != value))
				{
					this._ExpC = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ExpD", DbType="NVarChar(50)")]
		public string ExpD
		{
			get
			{
				return this._ExpD;
			}
			set
			{
				if ((this._ExpD != value))
				{
					this._ExpD = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OptionA", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string OptionA
		{
			get
			{
				return this._OptionA;
			}
			set
			{
				if ((this._OptionA != value))
				{
					this._OptionA = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OptionB", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string OptionB
		{
			get
			{
				return this._OptionB;
			}
			set
			{
				if ((this._OptionB != value))
				{
					this._OptionB = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OptionC", DbType="NVarChar(50)")]
		public string OptionC
		{
			get
			{
				return this._OptionC;
			}
			set
			{
				if ((this._OptionC != value))
				{
					this._OptionC = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OptionD", DbType="NVarChar(50)")]
		public string OptionD
		{
			get
			{
				return this._OptionD;
			}
			set
			{
				if ((this._OptionD != value))
				{
					this._OptionD = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Questions")]
	public partial class Questions : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _QuestionID;
		
		private string _QuestionTitle;
		
		private int _QuestionTypeID;
		
		private EntityRef<QuestionTypes> _QuestionTypes;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnQuestionIDChanging(int value);
    partial void OnQuestionIDChanged();
    partial void OnQuestionTitleChanging(string value);
    partial void OnQuestionTitleChanged();
    partial void OnQuestionTypeIDChanging(int value);
    partial void OnQuestionTypeIDChanged();
    #endregion
		
		public Questions()
		{
			this._QuestionTypes = default(EntityRef<QuestionTypes>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QuestionID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int QuestionID
		{
			get
			{
				return this._QuestionID;
			}
			set
			{
				if ((this._QuestionID != value))
				{
					this.OnQuestionIDChanging(value);
					this.SendPropertyChanging();
					this._QuestionID = value;
					this.SendPropertyChanged("QuestionID");
					this.OnQuestionIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QuestionTitle", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string QuestionTitle
		{
			get
			{
				return this._QuestionTitle;
			}
			set
			{
				if ((this._QuestionTitle != value))
				{
					this.OnQuestionTitleChanging(value);
					this.SendPropertyChanging();
					this._QuestionTitle = value;
					this.SendPropertyChanged("QuestionTitle");
					this.OnQuestionTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QuestionTypeID", DbType="Int NOT NULL")]
		public int QuestionTypeID
		{
			get
			{
				return this._QuestionTypeID;
			}
			set
			{
				if ((this._QuestionTypeID != value))
				{
					if (this._QuestionTypes.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnQuestionTypeIDChanging(value);
					this.SendPropertyChanging();
					this._QuestionTypeID = value;
					this.SendPropertyChanged("QuestionTypeID");
					this.OnQuestionTypeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="QuestionTypes_Questions", Storage="_QuestionTypes", ThisKey="QuestionTypeID", OtherKey="QuestionTypeID", IsForeignKey=true)]
		public QuestionTypes QuestionTypes
		{
			get
			{
				return this._QuestionTypes.Entity;
			}
			set
			{
				QuestionTypes previousValue = this._QuestionTypes.Entity;
				if (((previousValue != value) 
							|| (this._QuestionTypes.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._QuestionTypes.Entity = null;
						previousValue.Questions.Remove(this);
					}
					this._QuestionTypes.Entity = value;
					if ((value != null))
					{
						value.Questions.Add(this);
						this._QuestionTypeID = value.QuestionTypeID;
					}
					else
					{
						this._QuestionTypeID = default(int);
					}
					this.SendPropertyChanged("QuestionTypes");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.QuestionTypes")]
	public partial class QuestionTypes : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _QuestionTypeID;
		
		private string _TypeTitle;
		
		private EntitySet<Questions> _Questions;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnQuestionTypeIDChanging(int value);
    partial void OnQuestionTypeIDChanged();
    partial void OnTypeTitleChanging(string value);
    partial void OnTypeTitleChanged();
    #endregion
		
		public QuestionTypes()
		{
			this._Questions = new EntitySet<Questions>(new Action<Questions>(this.attach_Questions), new Action<Questions>(this.detach_Questions));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QuestionTypeID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int QuestionTypeID
		{
			get
			{
				return this._QuestionTypeID;
			}
			set
			{
				if ((this._QuestionTypeID != value))
				{
					this.OnQuestionTypeIDChanging(value);
					this.SendPropertyChanging();
					this._QuestionTypeID = value;
					this.SendPropertyChanged("QuestionTypeID");
					this.OnQuestionTypeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TypeTitle", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TypeTitle
		{
			get
			{
				return this._TypeTitle;
			}
			set
			{
				if ((this._TypeTitle != value))
				{
					this.OnTypeTitleChanging(value);
					this.SendPropertyChanging();
					this._TypeTitle = value;
					this.SendPropertyChanged("TypeTitle");
					this.OnTypeTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="QuestionTypes_Questions", Storage="_Questions", ThisKey="QuestionTypeID", OtherKey="QuestionTypeID")]
		public EntitySet<Questions> Questions
		{
			get
			{
				return this._Questions;
			}
			set
			{
				this._Questions.Assign(value);
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
		
		private void attach_Questions(Questions entity)
		{
			this.SendPropertyChanging();
			entity.QuestionTypes = this;
		}
		
		private void detach_Questions(Questions entity)
		{
			this.SendPropertyChanging();
			entity.QuestionTypes = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.RadioAnswers")]
	public partial class RadioAnswers
	{
		
		private int _QestionID;
		
		private string _Radio1;
		
		private string _Radio2;
		
		private string _Radio3;
		
		private string _Radio4;
		
		public RadioAnswers()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QestionID", DbType="Int NOT NULL")]
		public int QestionID
		{
			get
			{
				return this._QestionID;
			}
			set
			{
				if ((this._QestionID != value))
				{
					this._QestionID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Radio1", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Radio1
		{
			get
			{
				return this._Radio1;
			}
			set
			{
				if ((this._Radio1 != value))
				{
					this._Radio1 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Radio2", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Radio2
		{
			get
			{
				return this._Radio2;
			}
			set
			{
				if ((this._Radio2 != value))
				{
					this._Radio2 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Radio3", DbType="NVarChar(50)")]
		public string Radio3
		{
			get
			{
				return this._Radio3;
			}
			set
			{
				if ((this._Radio3 != value))
				{
					this._Radio3 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Radio4", DbType="NVarChar(50)")]
		public string Radio4
		{
			get
			{
				return this._Radio4;
			}
			set
			{
				if ((this._Radio4 != value))
				{
					this._Radio4 = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.StudentScores")]
	public partial class StudentScores
	{
		
		private int _UserID;
		
		private System.DateTime _LastTestDate;
		
		private string _Score;
		
		public StudentScores()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					this._UserID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastTestDate", DbType="Date NOT NULL")]
		public System.DateTime LastTestDate
		{
			get
			{
				return this._LastTestDate;
			}
			set
			{
				if ((this._LastTestDate != value))
				{
					this._LastTestDate = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Score", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string Score
		{
			get
			{
				return this._Score;
			}
			set
			{
				if ((this._Score != value))
				{
					this._Score = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TeacherLections")]
	public partial class TeacherLections
	{
		
		private int _UserID;
		
		private string _TheoryName;
		
		private string _Part1Name;
		
		private string _Part1;
		
		private string _Part2Name;
		
		private string _Part2;
		
		private string _Part3Name;
		
		private string _Part3;
		
		private string _Image;
		
		private string _Video;
		
		private string _Animation;
		
		private string _Audio;
		
		private bool _Hidden;
		
		public TeacherLections()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="Int NOT NULL")]
		public int UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					this._UserID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TheoryName", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string TheoryName
		{
			get
			{
				return this._TheoryName;
			}
			set
			{
				if ((this._TheoryName != value))
				{
					this._TheoryName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Part1Name", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Part1Name
		{
			get
			{
				return this._Part1Name;
			}
			set
			{
				if ((this._Part1Name != value))
				{
					this._Part1Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Part1", DbType="Text NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string Part1
		{
			get
			{
				return this._Part1;
			}
			set
			{
				if ((this._Part1 != value))
				{
					this._Part1 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Part2Name", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Part2Name
		{
			get
			{
				return this._Part2Name;
			}
			set
			{
				if ((this._Part2Name != value))
				{
					this._Part2Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Part2", DbType="Text NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string Part2
		{
			get
			{
				return this._Part2;
			}
			set
			{
				if ((this._Part2 != value))
				{
					this._Part2 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Part3Name", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Part3Name
		{
			get
			{
				return this._Part3Name;
			}
			set
			{
				if ((this._Part3Name != value))
				{
					this._Part3Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Part3", DbType="Text NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string Part3
		{
			get
			{
				return this._Part3;
			}
			set
			{
				if ((this._Part3 != value))
				{
					this._Part3 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Image", DbType="NVarChar(500) NOT NULL", CanBeNull=false)]
		public string Image
		{
			get
			{
				return this._Image;
			}
			set
			{
				if ((this._Image != value))
				{
					this._Image = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Video", DbType="NVarChar(500) NOT NULL", CanBeNull=false)]
		public string Video
		{
			get
			{
				return this._Video;
			}
			set
			{
				if ((this._Video != value))
				{
					this._Video = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Animation", DbType="NVarChar(500) NOT NULL", CanBeNull=false)]
		public string Animation
		{
			get
			{
				return this._Animation;
			}
			set
			{
				if ((this._Animation != value))
				{
					this._Animation = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Audio", DbType="NVarChar(500)")]
		public string Audio
		{
			get
			{
				return this._Audio;
			}
			set
			{
				if ((this._Audio != value))
				{
					this._Audio = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Hidden", DbType="Bit NOT NULL")]
		public bool Hidden
		{
			get
			{
				return this._Hidden;
			}
			set
			{
				if ((this._Hidden != value))
				{
					this._Hidden = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Users")]
	public partial class Users : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _UserID;
		
		private string _FirstName;
		
		private string _Name;
		
		private string _LastName;
		
		private string _Password;
		
		private int _TypeID;
		
		private EntityRef<UserTypes> _UserTypes;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserIDChanging(int value);
    partial void OnUserIDChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnTypeIDChanging(int value);
    partial void OnTypeIDChanged();
    #endregion
		
		public Users()
		{
			this._UserTypes = default(EntityRef<UserTypes>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					this.OnUserIDChanging(value);
					this.SendPropertyChanging();
					this._UserID = value;
					this.SendPropertyChanged("UserID");
					this.OnUserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TypeID", DbType="Int NOT NULL")]
		public int TypeID
		{
			get
			{
				return this._TypeID;
			}
			set
			{
				if ((this._TypeID != value))
				{
					if (this._UserTypes.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnTypeIDChanging(value);
					this.SendPropertyChanging();
					this._TypeID = value;
					this.SendPropertyChanged("TypeID");
					this.OnTypeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="UserTypes_Users", Storage="_UserTypes", ThisKey="TypeID", OtherKey="TypeID", IsForeignKey=true)]
		public UserTypes UserTypes
		{
			get
			{
				return this._UserTypes.Entity;
			}
			set
			{
				UserTypes previousValue = this._UserTypes.Entity;
				if (((previousValue != value) 
							|| (this._UserTypes.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._UserTypes.Entity = null;
						previousValue.Users.Remove(this);
					}
					this._UserTypes.Entity = value;
					if ((value != null))
					{
						value.Users.Add(this);
						this._TypeID = value.TypeID;
					}
					else
					{
						this._TypeID = default(int);
					}
					this.SendPropertyChanged("UserTypes");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.UserTypes")]
	public partial class UserTypes : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _TypeID;
		
		private string _UserType;
		
		private EntitySet<Users> _Users;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTypeIDChanging(int value);
    partial void OnTypeIDChanged();
    partial void OnUserTypeChanging(string value);
    partial void OnUserTypeChanged();
    #endregion
		
		public UserTypes()
		{
			this._Users = new EntitySet<Users>(new Action<Users>(this.attach_Users), new Action<Users>(this.detach_Users));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TypeID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int TypeID
		{
			get
			{
				return this._TypeID;
			}
			set
			{
				if ((this._TypeID != value))
				{
					this.OnTypeIDChanging(value);
					this.SendPropertyChanging();
					this._TypeID = value;
					this.SendPropertyChanged("TypeID");
					this.OnTypeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserType", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string UserType
		{
			get
			{
				return this._UserType;
			}
			set
			{
				if ((this._UserType != value))
				{
					this.OnUserTypeChanging(value);
					this.SendPropertyChanging();
					this._UserType = value;
					this.SendPropertyChanged("UserType");
					this.OnUserTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="UserTypes_Users", Storage="_Users", ThisKey="TypeID", OtherKey="TypeID")]
		public EntitySet<Users> Users
		{
			get
			{
				return this._Users;
			}
			set
			{
				this._Users.Assign(value);
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
		
		private void attach_Users(Users entity)
		{
			this.SendPropertyChanging();
			entity.UserTypes = this;
		}
		
		private void detach_Users(Users entity)
		{
			this.SendPropertyChanging();
			entity.UserTypes = null;
		}
	}
}
#pragma warning restore 1591
