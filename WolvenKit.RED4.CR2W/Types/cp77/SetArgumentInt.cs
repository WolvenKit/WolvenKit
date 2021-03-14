using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetArgumentInt : SetArguments
	{
		private CInt32 _customVar;

		[Ordinal(1)] 
		[RED("customVar")] 
		public CInt32 CustomVar
		{
			get
			{
				if (_customVar == null)
				{
					_customVar = (CInt32) CR2WTypeManager.Create("Int32", "customVar", cr2w, this);
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

		public SetArgumentInt(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
