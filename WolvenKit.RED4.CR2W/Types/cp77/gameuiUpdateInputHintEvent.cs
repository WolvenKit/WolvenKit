using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiUpdateInputHintEvent : redEvent
	{
		private gameuiInputHintData _data;
		private CBool _show;
		private CName _targetHintContainer;

		[Ordinal(0)] 
		[RED("data")] 
		public gameuiInputHintData Data
		{
			get
			{
				if (_data == null)
				{
					_data = (gameuiInputHintData) CR2WTypeManager.Create("gameuiInputHintData", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("show")] 
		public CBool Show
		{
			get
			{
				if (_show == null)
				{
					_show = (CBool) CR2WTypeManager.Create("Bool", "show", cr2w, this);
				}
				return _show;
			}
			set
			{
				if (_show == value)
				{
					return;
				}
				_show = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("targetHintContainer")] 
		public CName TargetHintContainer
		{
			get
			{
				if (_targetHintContainer == null)
				{
					_targetHintContainer = (CName) CR2WTypeManager.Create("CName", "targetHintContainer", cr2w, this);
				}
				return _targetHintContainer;
			}
			set
			{
				if (_targetHintContainer == value)
				{
					return;
				}
				_targetHintContainer = value;
				PropertySet(this);
			}
		}

		public gameuiUpdateInputHintEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
