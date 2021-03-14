using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsHotSpotActivationResult : CVariable
	{
		private CFloat _priority;

		[Ordinal(0)] 
		[RED("priority")] 
		public CFloat Priority
		{
			get
			{
				if (_priority == null)
				{
					_priority = (CFloat) CR2WTypeManager.Create("Float", "priority", cr2w, this);
				}
				return _priority;
			}
			set
			{
				if (_priority == value)
				{
					return;
				}
				_priority = value;
				PropertySet(this);
			}
		}

		public gameinteractionsHotSpotActivationResult(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
