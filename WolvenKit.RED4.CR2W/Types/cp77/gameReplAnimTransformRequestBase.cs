using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameReplAnimTransformRequestBase : CVariable
	{
		private netTime _applyServerTime;

		[Ordinal(0)] 
		[RED("applyServerTime")] 
		public netTime ApplyServerTime
		{
			get => GetProperty(ref _applyServerTime);
			set => SetProperty(ref _applyServerTime, value);
		}

		public gameReplAnimTransformRequestBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
