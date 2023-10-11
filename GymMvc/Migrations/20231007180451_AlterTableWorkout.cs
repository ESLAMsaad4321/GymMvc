using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymMvc.Migrations
{
    /// <inheritdoc />
    public partial class AlterTableWorkout : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "WorkOuts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "reps",
                table: "WorkOuts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "sets",
                table: "WorkOuts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "WorkOuts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "reps", "sets" },
                values: new object[] { "The dumbbell bench press is a version of the bench press that uses dumbbells instead of a barbell. Using two dumbbells and a bench, this exercise challenges the performer to lower both dumbbells to their chest before extending the arms to press them back up again. This bench press variation has an increased range of motion as the dumbbells can surpass the chest slightly.\r\n\r\nPrimarily targeting the chest muscles, the dumbbell press will activate the pectorals, triceps, and deltoids. The dumbbell bench press requires greater balance and stability so greater core engagement is needed.\r\n\r\nThe dumbbell bench press is great for beginners who want to build strength and stability before progressing to the barbell bench press, but equally valuable for intermediate and advanced lifters as a way to build unilateral strength and improve stability.\r\n\r\nThe dumbbell press can also be varied to regress the movement or add different challenges. For example, the neutral grip dumbbell press (palms facing each other) reduces involvement from the deltoids and places less stress on the shoulder joint, making it a suitable option for anyone wanting to focus on the chest and triceps while reducing injury risk, and the dumbbell floor press has a reduced range of movement which makes it suitable for beginners.\r\n\r\nThe dumbbell floor press has a reduced range of motion, making it a good option for beginners or those recovering from injury, while the alternating dumbbell bench press works shoulder and core stability more.", 15, 4 });

            migrationBuilder.UpdateData(
                table: "WorkOuts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "reps", "sets" },
                values: new object[] { "The seated chest press is a fixed weight machine that replicates the movement of a bench press in a seated position. Using the seated chest press works the pectorals, deltoids, and triceps, and has less requirement for stabilisation compared to a bench press due to the support from the machine.\r\n\r\nThe seated chest press is a great place to start if you’re new to weight training. Fixed resistance machines use a pre-determined movement path which enables the correct position to be adopted throughout the exercise to ensure the intended muscle groups are being used. This allows the lifter to build strength and become familiar with the movement while minimising injury risks.", 10, 3 });

            migrationBuilder.UpdateData(
                table: "WorkOuts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "reps", "sets" },
                values: new object[] { "The seated shoulder press machine is a fixed weight machine that replicates the movement of a seated shoulder press. The shoulder press machine primarily targets the deltoids, with some involvement from the triceps and clavicular head of the pecs.\r\n\r\nThe shoulder press machine is a great place to start if you’re new to weight training as it allows you to become familiar with the movement and strengthen the shoulders while minimising the risk of injury", 12, 2 });

            migrationBuilder.UpdateData(
                table: "WorkOuts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "reps", "sets" },
                values: new object[] { "The tricep pushdown uses a cable machine to train the tricep heads, with the medial and lateral heads mainly being targeted. The exercise involves pushing weight from around chest height down to the upper thigh. Both a straight bar and rope attachment can be used for this exercise.\r\n\r\nWith free weights, the tension is often reduced during the eccentric part of the movement (when the weight goes with gravity). Because the centre of gravity is different with a cable machine, tension is placed on the triceps throughout the entire movement, with greater focus on the eccentric portion of the movement compared to free weights, which can be beneficial for strength and hypertrophy.", 12, 3 });

            migrationBuilder.UpdateData(
                table: "WorkOuts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "reps", "sets" },
                values: new object[] { "The lat pull down machine is used to target the latissimus dorsi muscle (i.e. your back). It is typically performed seated, facing towards the machine, where you pull a long bar attached to the cable, towards your chest, and then slowly extend your arms back to starting position.\r\n\r\nThe lat pulldown can help to improve back strength and increase the size of your back muscles. It's a popular exercise for the back for beginners up until advanced gym goers. \r\n\r\nFor lat pulldown variations, check out our guides which include a step by step breakdown on how to perform the exercises below.", 10, 4 });

            migrationBuilder.UpdateData(
                table: "WorkOuts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "reps", "sets" },
                values: new object[] { "The barbell bent over row is an excellent upper body exercise that works the latissimus dorsi, the trapezius, the rhomboids, and the rear deltoids, with the core, biceps, and spinal erectors assisting the lift. The hip hinge setup of the row means that the lower body is also recruited for stability, with the glutes and hamstrings having to remain strong to maintain the correct position.\r\n\r\nThis compound exercise that builds strength and aids muscular hypertrophy, can help to improve posture, and protect the body against injury, and is well worth including in any training programme.\r\n\r\nThe barbell bent over row can use either an overhand (pronated) grip or an underhand (supinated) grip to alter which muscles are challenged. The pronated grip places greater focus on the lats, while the supinated grip recruits the biceps more. Most people can lift more load with a supinated grip.", 10, 3 });

            migrationBuilder.UpdateData(
                table: "WorkOuts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "reps", "sets" },
                values: new object[] { "The incline dumbbell row, or chest supported row, is a variation of the dumbbell bent over row where the perform leans the chest on an incline bench for support. Using the bench for support allows the torso to be at a 45-degree angle without relying on a hip hinge, which reduces the demand on the hamstrings and glutes and allows the back muscles to be challenged without being limited by lower body fatigue.\r\n\r\nThe incline dumbbell row targets the latissimus dorsi, rhomboids, trapezius, and rear deltoids. A neutral grip (palms facing each other) is commonly used, which may feel more comfortable on the shoulder joint. However, you can choose to vary the grip to create more focus on different muscles. A supinated (underhand) grip places more challenge on the biceps, while a pronated (overhand) grip engages the lats further.\r\n\r\nThe incline dumbbell row is a good option for those new to the bent over row as the bench provides stability and the correct position to perform the movement while reducing the stress placed on the lower back. It can also help to improve muscular imbalances between the two sides as each side works independently.", 10, 3 });

            migrationBuilder.UpdateData(
                table: "WorkOuts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "reps", "sets" },
                values: new object[] { "Face pulls use a cable machine with a rope attachment to train the rear deltoids, the muscles in the back of the shoulders, with support from the traps, rhomboids and rotator cuff. Strengthening these muscles can help with poor posture, improve shoulder stability, and help with overall shoulder and back strength.\r\n\r\nThe most popular of shoulder movements typically include pressing and raise movements which mostly work the anterior and lateral delts and neglect the rear delts. Including rear delt exercises like the face pull is important for building strong, healthy shoulders. It also helps to prevent muscular imbalances between the front and back of your body, which can lead to poor posture like slumping.", 15, 3 });

            migrationBuilder.UpdateData(
                table: "WorkOuts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "reps", "sets" },
                values: new object[] { "If you're reading this on a tablet or mobile your biceps are one of the muscles helping you hold your device. Located at the front of your upper arms, the bi-articular muscle helps control the motion of both the shoulder and elbow.  \r\n\r\nMaking up about one-third of your arms, the bicep is a highly visible muscle which means regularly performing bicep curls is a fantastically effective way to add definition and a toned look to your arms.\r\n\r\nThe biceps are one of your most-used muscles, essential to the forearm lifting motion. On a daily basis, hundreds of tasks involve bending your arm at the elbow and bicep curls will help make these actions easier to perform. An added bonus is a stronger grip, as holding the dumbbells used to perform the curls also trains your wrist and finger flexors. \r\n\r\nThe following isolation exercises will target your biceps and put you on the road to having stronger, healthier, more defined upper arms.", 14, 1 });

            migrationBuilder.UpdateData(
                table: "WorkOuts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "reps", "sets" },
                values: new object[] { "Squats are a great exercise if you're looking to improve your general fitness, tone your lower body, or build strength. Performing the squat requires using multiple muscle groups at the same time, making it an effective muscle-building compound movement to include into your workout routine. The main muscles groups used when doing a squat are the quadriceps, glutes and hamstrings.\r\n\r\nAlthough the squat is widely acknowledged as the ‘king of leg exercises’, other muscles groups are also involved, such as your core and even arms depending on the variation, so incorporating this exercise can help to tone your whole body.\r\n\r\nWhether you’re a complete beginner or a pro, this is a staple exercise to include into your gym routine. The squat can easily be adapted to suit your fitness level and abilities.\r\n\r\nFor beginners, the body weight squat, which is the most widely-known exercise would be a good one to start with. As you get more comfortable with the basic squat and your legs get stronger, you can make the squat more challenging by adding a variation that includes weights such as the barbell squat which used in Olympic weightlifting.", 10, 3 });

            migrationBuilder.UpdateData(
                table: "WorkOuts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "reps", "sets" },
                values: new object[] { "The leg press is a compound exercise performed on a seated resistance machine. It has a similar movement pattern to the squat, but unlike the squat which uses stabilising muscles in the upper body and core, the leg press is a lower body movement only. The quads are the main muscle recruited in a leg press, but the hamstrings, glutes, and calves are all worked to a lesser degree. \r\n\r\nLeg presses can be used alongside squats, or as a replacement. While squats are better at working the full body, the leg press makes a great alternative for anyone who can't squat, for example due to balance or mobility issues, or an upper body injury. Unlike squats, the leg press doesn't require any technical skill which makes it ideal for beginners too.\r\n\r\nThere are a few types of leg presses, with the most common being the 45 degree leg press and the seated leg press. The 45 degree leg press is the more challenging of the two as the plate is pushed at a 45 degree incline, and can have a higher weight as plates can be loaded on. The seated leg press is more suited for beginners, however both are used in the same way and work the same muscles.", 15, 4 });

            migrationBuilder.UpdateData(
                table: "WorkOuts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "reps", "sets" },
                values: new object[] { "Hamstring curls are isolation exercises which exclusively target the hamstrings. Isolation exercises often get a bad rep, but they can be really beneficial in addressing muscle imbalances. In this case, the hamstrings are typically weaker than the quadriceps, which means they don't always get pushed to full potential in compound movements as the quads take over. Combining compound movements with hamstring isolation exercises is the best way to increase the strength and size of your hamstrings. ", 15, 3 });

            migrationBuilder.UpdateData(
                table: "WorkOuts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "reps", "sets" },
                values: new object[] { "When you're looking to target your legs and bum, you can't beat a lunge. They're safe and easy to perform, you can do them anytime, anywhere, and they work out pretty much all the muscles in your lower body. Key muscles targeted include gluts, quads, hamstrings, calves and core.\r\n\r\nKnown as a unilateral exercise, lunges work out one side of your body at a time. This helps improve your overall stability, giving your better coordination and balance to perform everyday activities.\r\n\r\nAnother positive of training one side of your body at a time is it allows you to ensure both sides of the body are getting an equal work out, rather than letting your stronger side do more of the work. \r\n\r\nLunges are particularly effective in giving your core muscles a work out as it takes some effort to remain upright as you perform the lunge. A stronger core will go some way to improving your posture and warding off lower back pain.\r\n\r\nAs the exercise targets large muscle groups, it can help give your metabolism a boost which will aid weight loss and tone up key target areas on your legs and bottom. \r\n\r\nBefore you plunge right in and give it a go, be sure to check out our top tips and our guide to performing some of our favourite lunges. ", 12, 2 });

            migrationBuilder.UpdateData(
                table: "WorkOuts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "reps", "sets" },
                values: new object[] { "The calves are made up of two muscles, the gastrocnemius muscle and the soleus muscle. These muscles play a part in many body functions, including walking, running, jumping, standing on your toes, and flexing your feet. The calf muscles also help to pump blood around the body! When your calf muscles contract, it pushes the blood through the legs to heart, against the force of gravity. \r\n\r\nStrengthening your calves helps to protect against injuries in the feet, ankles, and knees, and can improve your circulation. While the calves do get worked in many lower body compound exercises like squats and deadlifts, it's very hard to create enough of a training stimulus to encourage significant muscle growth without isolating the calves. Adding calf specific exercises like calf raises into your workouts can help to strengthen the muscles much faster, so you get the benefits of strong calves. Training your calves in isolation also prevents them from lagging behind other muscles, which can increase the risk of injuries during lower body exercises. ", 30, 3 });

            migrationBuilder.UpdateData(
                table: "WorkOuts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "reps", "sets" },
                values: new object[] { "The rear delts, or posterior deltoids, are the muscles which sit on the back of your shoulders. The rear delts help to stabilise the shoulders, and work alongside the muscles in your back to prevent your shoulders from hunching forward. They also play a key part in pulling movements. \r\n\r\nPeople with desk jobs or sedentary lifestyles tend to have poor posture, which leads to lead to muscles in the posterior chain like the rear delts becoming weaker than anterior muscles. This further worsens the posture and can cause long term issues, including back pain. \r\n\r\nTraining the rear delts, along with your back muscles, glutes, and hamstrings, helps to combat these muscle imbalances and correct your posture.", 10, 3 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "WorkOuts");

            migrationBuilder.DropColumn(
                name: "reps",
                table: "WorkOuts");

            migrationBuilder.DropColumn(
                name: "sets",
                table: "WorkOuts");
        }
    }
}
