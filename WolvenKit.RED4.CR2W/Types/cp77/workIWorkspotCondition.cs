using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workIWorkspotCondition : ISerializable
	{
		private CEnum<workWorkspotLogic> _expectedResult;
		private CBool _equals;

		[Ordinal(0)] 
		[RED("expectedResult")] 
		public CEnum<workWorkspotLogic> ExpectedResult
		{
			get
			{
				if (_expectedResult == null)
				{
					_expectedResult = (CEnum<workWorkspotLogic>) CR2WTypeManager.Create("workWorkspotLogic", "expectedResult", cr2w, this);
				}
				return _expectedResult;
			}
			set
			{
				if (_expectedResult == value)
				{
					return;
				}
				_expectedResult = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("equals")] 
		public CBool Equals_
		{
			get
			{
				if (_equals == null)
				{
					_equals = (CBool) CR2WTypeManager.Create("Bool", "equals", cr2w, this);
				}
				return _equals;
			}
			set
			{
				if (_equals == value)
				{
					return;
				}
				_equals = value;
				PropertySet(this);
			}
		}

		public workIWorkspotCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
