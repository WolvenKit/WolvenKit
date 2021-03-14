using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CoopIrritationDelayCallback : gameDelaySystemScriptedDelayCallbackWrapper
	{
		private wCHandle<gameObject> _companion;

		[Ordinal(0)] 
		[RED("companion")] 
		public wCHandle<gameObject> Companion
		{
			get
			{
				if (_companion == null)
				{
					_companion = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "companion", cr2w, this);
				}
				return _companion;
			}
			set
			{
				if (_companion == value)
				{
					return;
				}
				_companion = value;
				PropertySet(this);
			}
		}

		public CoopIrritationDelayCallback(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
