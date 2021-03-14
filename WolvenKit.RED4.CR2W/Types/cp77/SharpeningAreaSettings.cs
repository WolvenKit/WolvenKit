using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SharpeningAreaSettings : IAreaSettings
	{
		private CFloat _sharpeningStrength;

		[Ordinal(2)] 
		[RED("sharpeningStrength")] 
		public CFloat SharpeningStrength
		{
			get
			{
				if (_sharpeningStrength == null)
				{
					_sharpeningStrength = (CFloat) CR2WTypeManager.Create("Float", "sharpeningStrength", cr2w, this);
				}
				return _sharpeningStrength;
			}
			set
			{
				if (_sharpeningStrength == value)
				{
					return;
				}
				_sharpeningStrength = value;
				PropertySet(this);
			}
		}

		public SharpeningAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
