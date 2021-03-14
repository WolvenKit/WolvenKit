using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class sampleTimeListener : tickScriptTimeDilationListener
	{
		private wCHandle<sampleTimeDilatable> _myOwner;

		[Ordinal(0)] 
		[RED("myOwner")] 
		public wCHandle<sampleTimeDilatable> MyOwner
		{
			get
			{
				if (_myOwner == null)
				{
					_myOwner = (wCHandle<sampleTimeDilatable>) CR2WTypeManager.Create("whandle:sampleTimeDilatable", "myOwner", cr2w, this);
				}
				return _myOwner;
			}
			set
			{
				if (_myOwner == value)
				{
					return;
				}
				_myOwner = value;
				PropertySet(this);
			}
		}

		public sampleTimeListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
