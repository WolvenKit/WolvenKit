using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ForkliftControllerPS : ScriptableDeviceComponentPS
	{
		private ForkliftSetup _forkliftSetup;
		private CBool _isUp;

		[Ordinal(103)] 
		[RED("forkliftSetup")] 
		public ForkliftSetup ForkliftSetup
		{
			get
			{
				if (_forkliftSetup == null)
				{
					_forkliftSetup = (ForkliftSetup) CR2WTypeManager.Create("ForkliftSetup", "forkliftSetup", cr2w, this);
				}
				return _forkliftSetup;
			}
			set
			{
				if (_forkliftSetup == value)
				{
					return;
				}
				_forkliftSetup = value;
				PropertySet(this);
			}
		}

		[Ordinal(104)] 
		[RED("isUp")] 
		public CBool IsUp
		{
			get
			{
				if (_isUp == null)
				{
					_isUp = (CBool) CR2WTypeManager.Create("Bool", "isUp", cr2w, this);
				}
				return _isUp;
			}
			set
			{
				if (_isUp == value)
				{
					return;
				}
				_isUp = value;
				PropertySet(this);
			}
		}

		public ForkliftControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
