using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ActivatedDeviceNPC : ActivatedDeviceTransfromAnim
	{
		private CBool _hasProperAnimations;

		[Ordinal(94)] 
		[RED("hasProperAnimations")] 
		public CBool HasProperAnimations
		{
			get
			{
				if (_hasProperAnimations == null)
				{
					_hasProperAnimations = (CBool) CR2WTypeManager.Create("Bool", "hasProperAnimations", cr2w, this);
				}
				return _hasProperAnimations;
			}
			set
			{
				if (_hasProperAnimations == value)
				{
					return;
				}
				_hasProperAnimations = value;
				PropertySet(this);
			}
		}

		public ActivatedDeviceNPC(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
