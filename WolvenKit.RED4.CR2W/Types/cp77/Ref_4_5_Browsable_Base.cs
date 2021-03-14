using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Ref_4_5_Browsable_Base : CVariable
	{
		private CInt32 _firstBaseVar;
		private CInt32 _secondBaseVar;
		private CInt32 _thirdBaseVar;

		[Ordinal(0)] 
		[RED("firstBaseVar")] 
		public CInt32 FirstBaseVar
		{
			get
			{
				if (_firstBaseVar == null)
				{
					_firstBaseVar = (CInt32) CR2WTypeManager.Create("Int32", "firstBaseVar", cr2w, this);
				}
				return _firstBaseVar;
			}
			set
			{
				if (_firstBaseVar == value)
				{
					return;
				}
				_firstBaseVar = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("secondBaseVar")] 
		public CInt32 SecondBaseVar
		{
			get
			{
				if (_secondBaseVar == null)
				{
					_secondBaseVar = (CInt32) CR2WTypeManager.Create("Int32", "secondBaseVar", cr2w, this);
				}
				return _secondBaseVar;
			}
			set
			{
				if (_secondBaseVar == value)
				{
					return;
				}
				_secondBaseVar = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("thirdBaseVar")] 
		public CInt32 ThirdBaseVar
		{
			get
			{
				if (_thirdBaseVar == null)
				{
					_thirdBaseVar = (CInt32) CR2WTypeManager.Create("Int32", "thirdBaseVar", cr2w, this);
				}
				return _thirdBaseVar;
			}
			set
			{
				if (_thirdBaseVar == value)
				{
					return;
				}
				_thirdBaseVar = value;
				PropertySet(this);
			}
		}

		public Ref_4_5_Browsable_Base(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
