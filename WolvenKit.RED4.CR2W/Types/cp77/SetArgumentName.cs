using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetArgumentName : SetArguments
	{
		private CName _customVar;

		[Ordinal(1)] 
		[RED("customVar")] 
		public CName CustomVar
		{
			get
			{
				if (_customVar == null)
				{
					_customVar = (CName) CR2WTypeManager.Create("CName", "customVar", cr2w, this);
				}
				return _customVar;
			}
			set
			{
				if (_customVar == value)
				{
					return;
				}
				_customVar = value;
				PropertySet(this);
			}
		}

		public SetArgumentName(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
