insert into t_role(RoleName)
   select 'admin' union
   select 'user'


   insert into t_user(UserName,NickName,UserRole,PassWord, CreateDate,Email, Credits)
   select 'admin','admin','1','123','2018-09-23','admin@123.com','50' union 
   select 'abc1','abc1','2','123','2018-09-23','abc1@123.com','50' union 
   select 'abc2','abc2','2','123','2018-09-23','abc2@123.com','50' union 
   select 'abc3','abc3','2','123','2018-09-23','abc3@123.com','50' union 
   select 'abc4','abc4','2','123' ,'2018-09-23','abc4@123.com','50'


   insert into t_question(Question, CreatorId, Answer)
   select 'You got an email saying you won the lottery. What would you do?', '1', 'delete it'union
   select 'Can hacker control camera in front of your laptop?', '1', 'yes'union
   select 'Can you share the password online?', '2', 'no'union
   select 'A new web page pops up.What do you do?', '2', 'close it'union
   select 'Someone try to contact you online. what would you do?', '2', 'tell your parents'


   insert into t_options (QuestionId, OptionId,  OptionContent)
   select '1','11', 'delete it'union
   select '1','12', 'click it'union
   select '1', '13','tell parents'union
   select '1','14', 'tell teachers'union
   select '2','21', 'yes'union
   select '2','22', 'no'union
   select '3','31', 'yes'union
   select '3','32', 'no'union
    select '4','41', 'delete it'union
   select '4','42', 'click it'union
   select '4', '43','tell parents'union
   select '4','44', 'tell teachers'union
    select '5','51', 'delete it'union
   select '5','52', 'click it'union
   select '5', '53','tell parents'union
   select '5','54', 'tell teachers'

   insert into t_quiz(QuizName, CreatorId, CreateDate, Duration)
   select 'quiz1', '1' , '2018-09-23', '10' union
   select 'quiz2', '2' , '2018-09-23', '10' 

   insert into t_Question_Quiz(QuizId,QuestionId)
   select '1', '1' union
   select '1', '2' union
   select '2', '3' union
   select '2', '4' union
   select '2', '5' 