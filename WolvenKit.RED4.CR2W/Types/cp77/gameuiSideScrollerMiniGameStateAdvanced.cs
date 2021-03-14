using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiSideScrollerMiniGameStateAdvanced : IScriptable
	{
		private CName _opertyMaxScore;
		private CName _opertyCurrentLives;
		private CName _opertyCurrentScore;
		private gameuiGameStatePropertyChangedCallback _propertyChanged;

		[Ordinal(0)] 
		[RED("opertyMaxScore")] 
		public CName OpertyMaxScore
		{
			get
			{
				if (_opertyMaxScore == null)
				{
					_opertyMaxScore = (CName) CR2WTypeManager.Create("CName", "opertyMaxScore", cr2w, this);
				}
				return _opertyMaxScore;
			}
			set
			{
				if (_opertyMaxScore == value)
				{
					return;
				}
				_opertyMaxScore = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("opertyCurrentLives")] 
		public CName OpertyCurrentLives
		{
			get
			{
				if (_opertyCurrentLives == null)
				{
					_opertyCurrentLives = (CName) CR2WTypeManager.Create("CName", "opertyCurrentLives", cr2w, this);
				}
				return _opertyCurrentLives;
			}
			set
			{
				if (_opertyCurrentLives == value)
				{
					return;
				}
				_opertyCurrentLives = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("opertyCurrentScore")] 
		public CName OpertyCurrentScore
		{
			get
			{
				if (_opertyCurrentScore == null)
				{
					_opertyCurrentScore = (CName) CR2WTypeManager.Create("CName", "opertyCurrentScore", cr2w, this);
				}
				return _opertyCurrentScore;
			}
			set
			{
				if (_opertyCurrentScore == value)
				{
					return;
				}
				_opertyCurrentScore = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("PropertyChanged")] 
		public gameuiGameStatePropertyChangedCallback PropertyChanged_
		{
			get
			{
				if (_propertyChanged == null)
				{
					_propertyChanged = (gameuiGameStatePropertyChangedCallback) CR2WTypeManager.Create("gameuiGameStatePropertyChangedCallback", "PropertyChanged", cr2w, this);
				}
				return _propertyChanged;
			}
			set
			{
				if (_propertyChanged == value)
				{
					return;
				}
				_propertyChanged = value;
				PropertySet(this);
			}
		}

		public gameuiSideScrollerMiniGameStateAdvanced(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
