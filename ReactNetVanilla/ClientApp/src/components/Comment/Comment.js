import React from 'react';
import styles from './Comment.module.css';

const Comment = (props) => {
  return (
    <div className={styles.Comment}>
      <h2>{props.author}</h2>
      {props.children}
    </div>
  );
}

export default Comment;
