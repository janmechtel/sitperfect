using Microsoft.Kinect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SitPerfect
{
    class MySkeleton
    {
        //
        // Summary:
        //     Gets or sets the skeleton's joints.
        public JointCollection Joints { get; protected set; }
        //
        // Summary:
        //     Gets or sets the skeleton's position.
        public SkeletonPoint Position { get; set; }
        //
        // Summary:
        //     Gets or sets the skeleton's tracking ID.
        public int TrackingId { get; set; }
        //
        // Summary:
        //     Gets or sets the skeleton's current tracking state.
        public SkeletonTrackingState TrackingState { get; set; }

        public DateTime Timestamp { get; set; }

        public MySkeleton(DateTime ts, Skeleton skel)
        {
            Timestamp = ts;
            Joints = skel.Joints;
            Position = skel.Position;
            TrackingId = skel.TrackingId;
            TrackingState = skel.TrackingState;
        }
    }
}
