using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RegisterUnitRequest : gameScriptableSystemRequest
	{
		private wCHandle<ScriptedPuppet> _unit;

		[Ordinal(0)] 
		[RED("unit")] 
		public wCHandle<ScriptedPuppet> Unit
		{
			get
			{
				if (_unit == null)
				{
					_unit = (wCHandle<ScriptedPuppet>) CR2WTypeManager.Create("whandle:ScriptedPuppet", "unit", cr2w, this);
				}
				return _unit;
			}
			set
			{
				if (_unit == value)
				{
					return;
				}
				_unit = value;
				PropertySet(this);
			}
		}

		public RegisterUnitRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
