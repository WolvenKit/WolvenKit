using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ActivateDevice : ActionBool
	{
		private CString _tweakDBChoiceName;

		[Ordinal(25)] 
		[RED("tweakDBChoiceName")] 
		public CString TweakDBChoiceName
		{
			get
			{
				if (_tweakDBChoiceName == null)
				{
					_tweakDBChoiceName = (CString) CR2WTypeManager.Create("String", "tweakDBChoiceName", cr2w, this);
				}
				return _tweakDBChoiceName;
			}
			set
			{
				if (_tweakDBChoiceName == value)
				{
					return;
				}
				_tweakDBChoiceName = value;
				PropertySet(this);
			}
		}

		public ActivateDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
