using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineeventPostponedParameterScriptable : gamestateMachineeventPostponedParameterBase
	{
		private CHandle<IScriptable> _value;

		[Ordinal(2)] 
		[RED("value")] 
		public CHandle<IScriptable> Value
		{
			get
			{
				if (_value == null)
				{
					_value = (CHandle<IScriptable>) CR2WTypeManager.Create("handle:IScriptable", "value", cr2w, this);
				}
				return _value;
			}
			set
			{
				if (_value == value)
				{
					return;
				}
				_value = value;
				PropertySet(this);
			}
		}

		public gamestateMachineeventPostponedParameterScriptable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
