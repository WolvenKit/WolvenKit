using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AutocraftDeactivateRequest : gameScriptableSystemRequest
	{
		private CBool _resetMemory;

		[Ordinal(0)] 
		[RED("resetMemory")] 
		public CBool ResetMemory
		{
			get
			{
				if (_resetMemory == null)
				{
					_resetMemory = (CBool) CR2WTypeManager.Create("Bool", "resetMemory", cr2w, this);
				}
				return _resetMemory;
			}
			set
			{
				if (_resetMemory == value)
				{
					return;
				}
				_resetMemory = value;
				PropertySet(this);
			}
		}

		public AutocraftDeactivateRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
