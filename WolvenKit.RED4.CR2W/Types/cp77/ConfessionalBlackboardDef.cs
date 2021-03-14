using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ConfessionalBlackboardDef : DeviceBaseBlackboardDef
	{
		private gamebbScriptID_Bool _isConfessing;

		[Ordinal(7)] 
		[RED("IsConfessing")] 
		public gamebbScriptID_Bool IsConfessing
		{
			get
			{
				if (_isConfessing == null)
				{
					_isConfessing = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "IsConfessing", cr2w, this);
				}
				return _isConfessing;
			}
			set
			{
				if (_isConfessing == value)
				{
					return;
				}
				_isConfessing = value;
				PropertySet(this);
			}
		}

		public ConfessionalBlackboardDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
