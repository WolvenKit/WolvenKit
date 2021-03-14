using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Reprimand : MorphData
	{
		private ReprimandData _reprimandData;

		[Ordinal(1)] 
		[RED("reprimandData")] 
		public ReprimandData ReprimandData
		{
			get
			{
				if (_reprimandData == null)
				{
					_reprimandData = (ReprimandData) CR2WTypeManager.Create("ReprimandData", "reprimandData", cr2w, this);
				}
				return _reprimandData;
			}
			set
			{
				if (_reprimandData == value)
				{
					return;
				}
				_reprimandData = value;
				PropertySet(this);
			}
		}

		public Reprimand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
