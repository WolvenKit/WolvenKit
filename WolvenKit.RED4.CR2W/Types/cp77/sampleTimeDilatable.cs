using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class sampleTimeDilatable : gameTimeDilatable
	{
		private CHandle<sampleTimeListener> _listener;

		[Ordinal(40)] 
		[RED("listener")] 
		public CHandle<sampleTimeListener> Listener
		{
			get
			{
				if (_listener == null)
				{
					_listener = (CHandle<sampleTimeListener>) CR2WTypeManager.Create("handle:sampleTimeListener", "listener", cr2w, this);
				}
				return _listener;
			}
			set
			{
				if (_listener == value)
				{
					return;
				}
				_listener = value;
				PropertySet(this);
			}
		}

		public sampleTimeDilatable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
