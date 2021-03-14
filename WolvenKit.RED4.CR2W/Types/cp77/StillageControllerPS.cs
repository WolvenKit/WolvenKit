using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StillageControllerPS : ScriptableDeviceComponentPS
	{
		private CBool _isCleared;

		[Ordinal(103)] 
		[RED("isCleared")] 
		public CBool IsCleared
		{
			get
			{
				if (_isCleared == null)
				{
					_isCleared = (CBool) CR2WTypeManager.Create("Bool", "isCleared", cr2w, this);
				}
				return _isCleared;
			}
			set
			{
				if (_isCleared == value)
				{
					return;
				}
				_isCleared = value;
				PropertySet(this);
			}
		}

		public StillageControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
