using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class customGameNotificationDataSet : inkGameNotificationData
	{
		private CName _customText;
		private CBool _testBool;

		[Ordinal(6)] 
		[RED("customText")] 
		public CName CustomText
		{
			get
			{
				if (_customText == null)
				{
					_customText = (CName) CR2WTypeManager.Create("CName", "customText", cr2w, this);
				}
				return _customText;
			}
			set
			{
				if (_customText == value)
				{
					return;
				}
				_customText = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("testBool")] 
		public CBool TestBool
		{
			get
			{
				if (_testBool == null)
				{
					_testBool = (CBool) CR2WTypeManager.Create("Bool", "testBool", cr2w, this);
				}
				return _testBool;
			}
			set
			{
				if (_testBool == value)
				{
					return;
				}
				_testBool = value;
				PropertySet(this);
			}
		}

		public customGameNotificationDataSet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
