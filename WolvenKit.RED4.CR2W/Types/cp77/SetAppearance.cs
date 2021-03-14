using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetAppearance : AIActionHelperTask
	{
		private CName _appearance;

		[Ordinal(5)] 
		[RED("appearance")] 
		public CName Appearance
		{
			get
			{
				if (_appearance == null)
				{
					_appearance = (CName) CR2WTypeManager.Create("CName", "appearance", cr2w, this);
				}
				return _appearance;
			}
			set
			{
				if (_appearance == value)
				{
					return;
				}
				_appearance = value;
				PropertySet(this);
			}
		}

		public SetAppearance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
