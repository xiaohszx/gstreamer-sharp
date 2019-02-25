// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Video {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Gst.Video.VideoAncillaryDIDGType))]
	public enum VideoAncillaryDID {

		Undefined = 0,
		Deletion = 128,
		Hanc3gAudioDataFirst = 160,
		Hanc3gAudioDataLast = 167,
		HancHdtvAudioDataFirst = 224,
		HancHdtvAudioDataLast = 231,
		HancSdtvAudioData1First = 236,
		HancSdtvAudioData1Last = 239,
		CameraPosition = 240,
		HancErrorDetection = 244,
		HancSdtvAudioData2First = 248,
		HancSdtvAudioData2Last = 255,
	}

	internal class VideoAncillaryDIDGType {
		[DllImport ("libgstvideo-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_video_ancillary_did_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_video_ancillary_did_get_type ());
			}
		}
	}
#endregion
}
