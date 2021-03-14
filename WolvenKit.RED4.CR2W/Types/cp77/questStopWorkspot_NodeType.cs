using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questStopWorkspot_NodeType : questIBehaviourManager_NodeType
	{
		private CBool _allowCurrAnimToFinish;
		private CName _exitAnim;

		[Ordinal(1)] 
		[RED("allowCurrAnimToFinish")] 
		public CBool AllowCurrAnimToFinish
		{
			get
			{
				if (_allowCurrAnimToFinish == null)
				{
					_allowCurrAnimToFinish = (CBool) CR2WTypeManager.Create("Bool", "allowCurrAnimToFinish", cr2w, this);
				}
				return _allowCurrAnimToFinish;
			}
			set
			{
				if (_allowCurrAnimToFinish == value)
				{
					return;
				}
				_allowCurrAnimToFinish = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("exitAnim")] 
		public CName ExitAnim
		{
			get
			{
				if (_exitAnim == null)
				{
					_exitAnim = (CName) CR2WTypeManager.Create("CName", "exitAnim", cr2w, this);
				}
				return _exitAnim;
			}
			set
			{
				if (_exitAnim == value)
				{
					return;
				}
				_exitAnim = value;
				PropertySet(this);
			}
		}

		public questStopWorkspot_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
